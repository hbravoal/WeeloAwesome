using AutoMapper;
using System.Linq;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Weelo.Application.Filters;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Application.Wrappers;
using Microsoft.EntityFrameworkCore;
using Weelo.Application.Services;

namespace Weelo.Application.Features.Properties.Queries.GetAll
{
    public class GetAllPropertiesQuery : IRequest<PagedResponse<IEnumerable<GetAllPropertiesViewModel>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
    public class GetAllPropertiesQueryHandler : IRequestHandler<GetAllPropertiesQuery, PagedResponse<IEnumerable<GetAllPropertiesViewModel>>>
    {
        private readonly IPropertyRepositoryAsync _repository;
        private readonly IMapper _mapper;
        private readonly IDataProtectionHelper _dataProtectionHelper;

        public GetAllPropertiesQueryHandler(IPropertyRepositoryAsync repository, IMapper mapper,Services.IDataProtectionHelper dataProtectionHelper)
        {
            _repository = repository;
            _mapper = mapper;
            _dataProtectionHelper = dataProtectionHelper;
        }

        public async Task<PagedResponse<IEnumerable<GetAllPropertiesViewModel>>> Handle(GetAllPropertiesQuery request, CancellationToken cancellationToken)
        {
            var validFilter = _mapper.Map<GetAllPropertiesParameter>(request);

            var product =await 
                Task.Run(() =>
                {
                    return _repository.GetPagedReponse(validFilter.PageNumber, validFilter.PageSize).Include(c => c.PropertyImages).ToList();
                });

            var productViewModel = _mapper.Map<IEnumerable<GetAllPropertiesViewModel>>(product);
            productViewModel=productViewModel.Select(c => { c.Id = _dataProtectionHelper.Encrypt(Convert.ToString(c.Id));c.PropertyImages.Select(c => c.Id = _dataProtectionHelper.Encrypt(Convert.ToString(c.Id))); return c; });            
            
            return new PagedResponse<IEnumerable<GetAllPropertiesViewModel>>(productViewModel, validFilter.PageNumber, validFilter.PageSize);
        }
    }
}
