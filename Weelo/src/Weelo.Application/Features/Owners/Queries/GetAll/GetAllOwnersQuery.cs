using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Application.Wrappers;

namespace Weelo.Application.Features.Owners.Queries.GetAll
{
    public class GetAllOwnersQuery : IRequest<PagedResponse<IEnumerable<GetAllOwnersViewModel>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
    public class GetAllOwnersQueryHandler : IRequestHandler<GetAllOwnersQuery, PagedResponse<IEnumerable<GetAllOwnersViewModel>>>
    {
        private readonly IOwnerRepositoryAsync _target;
        private readonly IMapper _mapper;
        public GetAllOwnersQueryHandler(IOwnerRepositoryAsync target, IMapper mapper)
        {
            _target = target;
            _mapper = mapper;
        }

        public async Task<PagedResponse<IEnumerable<GetAllOwnersViewModel>>> Handle(GetAllOwnersQuery request, CancellationToken cancellationToken)
        {
            var validFilter = _mapper.Map<GetAllOwnersParameter>(request);
            var result = await _target.GetPagedReponseAsync(validFilter.PageNumber, validFilter.PageSize);
            var resultViewModel= _mapper.Map<IEnumerable<GetAllOwnersViewModel>>(result);
            return new PagedResponse<IEnumerable<GetAllOwnersViewModel>>(resultViewModel, validFilter.PageNumber, validFilter.PageSize);
        }
    }
}
