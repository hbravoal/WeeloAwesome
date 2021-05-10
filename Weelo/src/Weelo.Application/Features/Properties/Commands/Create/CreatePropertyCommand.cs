using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Application.Wrappers;
using Weelo.Domain.Entities;

namespace Weelo.Application.Features.Properties.Commands.Create
{
    public partial class CreatePropertyCommand : IRequest<Response<int>>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Price { get; set; }
        public decimal CodeInternal { get; set; }
        public string Year { get; set; }
        public int OwnerId { get; set; }
    }
    public class CreatePropertyCommandHandler : IRequestHandler<CreatePropertyCommand, Response<int>>
    {
        private readonly IPropertyRepositoryAsync _targetRepository;
        private readonly IMapper _mapper;
        public CreatePropertyCommandHandler(IPropertyRepositoryAsync targetRepository, IMapper mapper)
        {
            _targetRepository = targetRepository;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreatePropertyCommand request, CancellationToken cancellationToken)
        {
            var mapperResponse = _mapper.Map<Property>(request);
            await _targetRepository.AddAsync(mapperResponse);
            return new Response<int>(mapperResponse.Id);
        }
    }
}
