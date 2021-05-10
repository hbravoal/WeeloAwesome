using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Weelo.Application.Exceptions;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Application.Wrappers;
using Weelo.Domain.Entities;

namespace Weelo.Application.Features.Products.Queries.GetProductById
{
    public class GetOwnerByIdQuery : IRequest<Response<Owner>>
    {
        public int Id { get; set; }
        public class GetOwnerByIdQueryHandler : IRequestHandler<GetOwnerByIdQuery, Response<Owner>>
        {
            private readonly IOwnerRepositoryAsync _target;
            public GetOwnerByIdQueryHandler(IOwnerRepositoryAsync target)
            {
                _target = target;
            }
            public async Task<Response<Owner>> Handle(GetOwnerByIdQuery query, CancellationToken cancellationToken)
            {
                var result = await _target.GetByIdAsync(query.Id);
                if (result == null) throw new ApiException($"Owner Not Found.");
                return new Response<Owner>(result);
            }
        }
    }
}
