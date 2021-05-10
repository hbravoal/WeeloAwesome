using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Weelo.Application.Exceptions;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Application.Wrappers;

namespace Weelo.Application.Features.PropertyTraces.Commands.UpdateProduct
{
    public class UpdatePropertyTraceCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public decimal Tax { get; set; }
        public DateTime DateSale { get; set; }
        public bool Enabled { get; set; }
        public class UpdatePropertyTraceCommandHandler : IRequestHandler<UpdatePropertyTraceCommand, Response<int>>
        {
            private readonly IPropertyTraceRepositoryAsync _target;
            public UpdatePropertyTraceCommandHandler(IPropertyTraceRepositoryAsync target)
            {
                _target = target;
            }
            public async Task<Response<int>> Handle(UpdatePropertyTraceCommand command, CancellationToken cancellationToken)
            {
                var result = await _target.GetByIdAsync(command.Id);

                if (result == null)
                {
                    throw new ApiException($"PropertyTrace Not Found.");
                }
                else
                {
                    result.Name = command.Name;
                    result.Tax = command.Tax;
                    result.Value = command.Value;
                    result.DateSale = command.DateSale;
                    result.Enabled = command.Enabled;
                    await _target.UpdateAsync(result);
                    return new Response<int>(result.Id);
                }
            }
        }
    }
}
