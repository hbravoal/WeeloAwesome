using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Weelo.Application.Exceptions;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Application.Wrappers;

namespace Weelo.Application.Features.Products.Commands.DeleteProductById
{
    public class DeleteOwnerByIdCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
        public class DeleteOwnerByIdCommandHandler : IRequestHandler<DeleteOwnerByIdCommand, Response<int>>
        {
            private readonly IOwnerRepositoryAsync _target;
            public DeleteOwnerByIdCommandHandler(IOwnerRepositoryAsync target)
            {
                _target = target;
            }
            public async Task<Response<int>> Handle(DeleteOwnerByIdCommand command, CancellationToken cancellationToken)
            {
                var result = await _target.GetByIdAsync(command.Id);
                if (result == null) throw new ApiException($"Owner Not Found.");
                await _target.DeleteAsync(result);
                return new Response<int>(result.Id);
            }
        }
    }
}
