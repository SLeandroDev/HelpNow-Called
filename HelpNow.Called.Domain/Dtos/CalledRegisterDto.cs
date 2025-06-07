using HelpNow.Called.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpNow.Called.Domain.Dtos;
public class CalledRegisterDto
{
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public StatusChamado StatusChamado { get; set; }
    public int SolicitanteId { get; set; }
}
