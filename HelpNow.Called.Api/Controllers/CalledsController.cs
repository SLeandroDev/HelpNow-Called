using HelpNow.Called.Application.Services;
using HelpNow.Called.Domain.Dtos;
using HelpNow.Called.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HelpNow.Called.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CalledsController(ICalledService calledService) : ControllerBase
{
    private readonly ICalledService _calledService = calledService;
    [HttpPost]
    [Route("criar-chamado")]
    public async Task<IActionResult> CriarChamado([FromBody] CalledRegisterDto dto)
    {
        await _calledService.CriarChamadoAsync(dto);
        return Created("", new { message = "Chamado criado com sucesso!" });
    }
}
