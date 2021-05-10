using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Domain.Entities;

namespace Weelo.Application.Features.Owners.Commands.Create
{
    public class CreateOwnerCommandValidator : AbstractValidator<CreateOwnerCommand>
    {

        public CreateOwnerCommandValidator()
        {

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.Address)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

        }

    }
}
