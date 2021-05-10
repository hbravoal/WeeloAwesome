using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Weelo.Application.Exceptions;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Application.Wrappers;

namespace Weelo.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateOwnerCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public DateTime Birthday { get; set; }
        public class UpdateOwnerCommandHandler : IRequestHandler<UpdateOwnerCommand, Response<int>>
        {
            private readonly IOwnerRepositoryAsync _target;
            public UpdateOwnerCommandHandler(IOwnerRepositoryAsync target)
            {
                _target = target;
            }
            public async Task<Response<int>> Handle(UpdateOwnerCommand command, CancellationToken cancellationToken)
            {
                var result = await _target.GetByIdAsync(command.Id);

                if (result == null)
                {
                    throw new ApiException($"Owner Not Found.");
                }
                else
                {
                    result.Name = command.Name;
                    result.Address = command.Address;
                    result.Photo = command.Photo;
                    result.Birthday= command.Birthday;
                    await _target.UpdateAsync(result);
                    return new Response<int>(result.Id);
                }
            }
        }
    }
}
