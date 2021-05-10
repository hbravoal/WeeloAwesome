using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Application.Wrappers;

namespace Weelo.Application.Features.PropertyTraces.Queries.GetAll
{
    public class GetAllPropertyTracesQuery : IRequest<PagedResponse<IEnumerable<GetAllPropertyTracesViewModel>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
    public class GetAllPropertyTracesQueryHandler : IRequestHandler<GetAllPropertyTracesQuery, PagedResponse<IEnumerable<GetAllPropertyTracesViewModel>>>
    {
        private readonly IPropertyTraceRepositoryAsync _repository;
        private readonly IMapper _mapper;
        public GetAllPropertyTracesQueryHandler(IPropertyTraceRepositoryAsync repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<PagedResponse<IEnumerable<GetAllPropertyTracesViewModel>>> Handle(GetAllPropertyTracesQuery request, CancellationToken cancellationToken)
        {
            var validFilter = _mapper.Map<GetAllPropertyTracesParameter>(request);
            var result = await _repository.GetPagedReponseAsync(validFilter.PageNumber, validFilter.PageSize);
            var resultViewModel= _mapper.Map<IEnumerable<GetAllPropertyTracesViewModel>>(result);
            return new PagedResponse<IEnumerable<GetAllPropertyTracesViewModel>>(resultViewModel, validFilter.PageNumber, validFilter.PageSize);
        }
    }
}
