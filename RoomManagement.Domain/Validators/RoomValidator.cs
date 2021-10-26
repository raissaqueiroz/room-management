using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using RoomManagement.Domain.Entities;

namespace RoomManagement.Domain.Validators
{
    public class RoomValidator : AbstractValidator<Room>
    {
        public RoomValidator()
        {
            RuleFor(x => x)
                .NotEmpty()
                .WithMessage("A entidade não pode ser vazia")

                .NotNull()
                .WithMessage("A entidade não pode ser nula");
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("O Nome não pode ser vazio")

                .NotNull()
                .WithMessage("O Nome não pode ser nulo")

                .MinimumLength(6)
                .WithMessage("O nome deve conter no minimo 3 caracteres")

                .MaximumLength(80)
                .WithMessage("O nome deve conter no maximo 60 caracteres");
        }
        
    }
}