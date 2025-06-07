using HelpNow.Called.Domain.Dtos;
using HelpNow.Called.Domain.Interfaces;
using HelpNow.Called.Domain.Models;
using BCrypt.Net;

namespace HelpNow.Called.Application.Services;
public class CalledService(ICalledRepository calledRepository) : ICalledService
{
    private readonly ICalledRepository _calledRepository = calledRepository;
    public async Task CriarChamadoAsync(CalledRegisterDto dto)
    {
        var called = new CalledModel
        {
            Titulo = dto.Titulo,
            Descricao = dto.Descricao,
            SolicitanteId = dto.SolicitanteId,
            DtCriacao = DateTime.Now,
            Status = dto.StatusChamado
        };

        await _calledRepository.AdicionarChamadoAsync(called);
    }
}
