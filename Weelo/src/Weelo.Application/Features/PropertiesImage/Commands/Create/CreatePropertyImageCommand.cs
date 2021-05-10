using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Application.Services;
using Weelo.Application.Wrappers;
using Weelo.Domain.Entities;

namespace Weelo.Application.Features.PropertiesImage.Commands.Create
{
    public class CreatePropertyImageCommand : IRequest<Response<int>>
    {
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public Microsoft.AspNetCore.Http.IFormFile File { get; set; }
        //public string File { get; set; }
        public bool Enabled { get; set; }
        public int PropertyId { get; set; }
    }
    public class CreatePropertyImageCommandHandler : IRequestHandler<CreatePropertyImageCommand, Response<int>>
    {
        private readonly IPropertyImageRepositoryAsync _repository;
        private readonly IMapper _mapper;
        public static Microsoft.Extensions.Hosting.IHostEnvironment _environment;
        private readonly IDataProtectionHelper _dataProtectionHelper;

        public CreatePropertyImageCommandHandler(IPropertyImageRepositoryAsync repository, IMapper mapper,
            Microsoft.Extensions.Hosting.IHostEnvironment environment, Services.IDataProtectionHelper dataProtectionHelper)
        {
            _repository = repository;
            _mapper = mapper;
            _environment = environment;
            _dataProtectionHelper = dataProtectionHelper;
        }

        public async Task<Response<int>> Handle(CreatePropertyImageCommand request, CancellationToken cancellationToken)
        {

            //TODO: Optimizing GetEntryAssembly -> Why? Visual's Daemon don't work for autoc for usings.
                try
                {
                string path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "uploads");
                if (!System.IO.Directory.Exists(path))
                    {
                        System.IO.Directory.CreateDirectory(path);
                    }
                
                var extension = System.IO.Path.GetExtension(request.File.FileName);
                string imageName = request.File.FileName + extension;
                string imageContainer = _dataProtectionHelper.Encrypt(imageName);
                string pathImage = System.IO.Path.Combine(path, imageContainer);
                pathImage += extension;



                using (System.IO.FileStream filestream = System.IO.File.Create(pathImage))
                    {
                        request.File.CopyTo(filestream);
                        filestream.Flush();
                    string filepath = imageContainer;
                        var result = _mapper.Map<PropertyImage>(request);
                    
                            result.File = filepath;
                        await _repository.AddAsync(result);
                        return new Response<int>(result.Id);
                    }
                }
                catch (System.Exception ex)
                {
                throw new System.Exception(ex.ToString());
                }
            
           

        }
    }
}
