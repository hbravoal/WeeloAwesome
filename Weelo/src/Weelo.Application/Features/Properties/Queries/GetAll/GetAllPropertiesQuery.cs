using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Weelo.Application.Filters;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Application.Wrappers;

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
        public GetAllPropertiesQueryHandler(IPropertyRepositoryAsync repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PagedResponse<IEnumerable<GetAllPropertiesViewModel>>> Handle(GetAllPropertiesQuery request, CancellationToken cancellationToken)
        {
            var validFilter = _mapper.Map<GetAllPropertiesParameter>(request);
            var product = await _repository.GetPagedReponseAsync(validFilter.PageNumber, validFilter.PageSize);
            var productViewModel = _mapper.Map<IEnumerable<GetAllPropertiesViewModel>>(product);
            return new PagedResponse<IEnumerable<GetAllPropertiesViewModel>>(productViewModel, validFilter.PageNumber, validFilter.PageSize);
        }
    }
}
