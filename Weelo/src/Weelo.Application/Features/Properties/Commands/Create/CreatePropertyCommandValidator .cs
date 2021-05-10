using FluentValidation;
using System.Threading;
using System.Threading.Tasks;
using Weelo.Application.Features.Properties.Commands.Create;
using Weelo.Application.Interfaces.Repositories;

namespace Weelo.Application.Features.Products.Commands.CreateProduct
{
    public class CreatePropertyCommandValidator : AbstractValidator<CreatePropertyCommand>
    {
        private readonly IOwnerRepositoryAsync _repository;
        
        public CreatePropertyCommandValidator(IOwnerRepositoryAsync repositoryAsync)
        {
            _repository = repositoryAsync;
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.Price)
                .GreaterThan(0).WithMessage("{PropertyName} must be grean than 0.")
                .NotNull().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.OwnerId).
           MustAsync(IsValidOwner).WithMessage("{PropertyName} Not  exists.");

        }
        private async Task<bool> IsValidOwner(int ownerId, CancellationToken cancellationToken)
        {
            var response= await _repository.GetByIdAsync(ownerId);
            if (response != null && response.Id >= 0)
                return true;
            return false;
        }

    }
}
