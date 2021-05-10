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

namespace Weelo.Application.Features.PropertiesImage.Commands.Create
{
    public class CreatePropertyImageCommandValidator : AbstractValidator<CreatePropertyImageCommand>
    {

        public CreatePropertyImageCommandValidator( )
        {

            RuleFor(p => p.File)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
               ;

           

        }

  
    }
}
