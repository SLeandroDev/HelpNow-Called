using HelpNow.Called.Domain.Enums;

namespace HelpNow.Called.Domain.Models;

public class CalledModel
{
    public int? Id { get; set; }
    public string Titulo { get; set; } = null!;
    public string Descricao { get; set; } = null!;
    public int SolicitanteId { get; set; }
    public int? AtendenteId { get; set; }
    public StatusChamado Status { get; set; }
    public DateTime DtCriacao { get; set; }
    public DateTime? DtAtualizacao { get; set; }
    public DateTime? DtFechamento { get; set; }
}