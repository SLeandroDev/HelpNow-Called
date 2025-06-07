using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HelpNow.Called.Domain.Enums;

namespace HelpNow.Called.Domain.Dtos;
public class CalledRegisterDtoValidator : AbstractValidator<CalledRegisterDto>
{
    public CalledRegisterDtoValidator()
    {
        RuleFor(x => x.Titulo).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Descricao).NotEmpty();
        RuleFor(x => x.StatusChamado)
        .Must(x => Enum.IsDefined(typeof(StatusChamado), x))
        .WithMessage("TpAcesso inválido.");
    }
}
