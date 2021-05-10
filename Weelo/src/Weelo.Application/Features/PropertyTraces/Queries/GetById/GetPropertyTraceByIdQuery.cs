using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Weelo.Application.Exceptions;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Application.Wrappers;
using Weelo.Domain.Entities;

namespace Weelo.Application.Features.PropertyTraces.Queries.GetById
{
    public class GetPropertyTraceByIdQuery : IRequest<Response<PropertyTrace>>
    {
        public int Id { get; set; }
        public class GetPropertyTraceByIdQueryHandler : IRequestHandler<GetPropertyTraceByIdQuery, Response<PropertyTrace>>
        {
            private readonly IPropertyTraceRepositoryAsync _target;
            public GetPropertyTraceByIdQueryHandler(IPropertyTraceRepositoryAsync target)
            {
                _target = target;
            }
            public async Task<Response<PropertyTrace>> Handle(GetPropertyTraceByIdQuery query, CancellationToken cancellationToken)
            {
                var result = await _target.GetByIdAsync(query.Id);
                if (result == null) throw new ApiException($"Trace Not Found.");
                return new Response<PropertyTrace>(result);
            }
        }
    }
}
