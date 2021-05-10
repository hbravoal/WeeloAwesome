using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Weelo.Application.Exceptions;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Application.Wrappers;

namespace Weelo.Application.Features.PropertyTraces.Commands.DeleteProductById
{
    public class DeletePropertyTraceByIdCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
        public class DeletePropertyTraceByIdCommandHandler : IRequestHandler<DeletePropertyTraceByIdCommand, Response<int>>
        {
            private readonly IPropertyTraceRepositoryAsync _target;
            public DeletePropertyTraceByIdCommandHandler(IPropertyTraceRepositoryAsync target)
            {
                _target = target;
            }
            public async Task<Response<int>> Handle(DeletePropertyTraceByIdCommand command, CancellationToken cancellationToken)
            {
                var result = await _target.GetByIdAsync(command.Id);
                if (result == null) throw new ApiException($"PropertyTrace Not Found.");
                await _target.DeleteAsync(result);
                return new Response<int>(result.Id);
            }
        }
    }
}
