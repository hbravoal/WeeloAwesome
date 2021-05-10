using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Weelo.Application.Interfaces.Repositories;


namespace Weelo.Application.Features.Properties.Commands.Create
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
            RuleFor(p => p.OwnerId)
                .GreaterThan(0).WithMessage("{PropertyName} must be grean than 0.")                
                .MustAsync(IsValidOwner).WithMessage("{PropertyName} Not  exists.");

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
