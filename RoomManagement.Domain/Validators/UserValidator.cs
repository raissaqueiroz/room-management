using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using RoomManagement.Domain.Entities;

namespace RoomManagement.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
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

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("O E-mail não pode ser vazio")

                .NotNull()
                .WithMessage("O E-mail não pode ser nulo")

                .MinimumLength(6)
                .WithMessage("O E-mail deve conter no minimo 10 caracteres")

                .MaximumLength(80)
                .WithMessage("O E-mail deve conter no maximo 180 caracteres")
                
                .Matches(@"/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$/")
                .WithMessage("o E-mail informado não é válido");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("A Senha não pode ser vazio")

                .NotNull()
                .WithMessage("A Senha não pode ser nulo")

                .MinimumLength(6)
                .WithMessage("A Senhal deve conter no minimo 6 caracteres")

                .MaximumLength(80)
                .WithMessage("A Senha deve conter no maximo 30 caracteres");

        }
    }
}