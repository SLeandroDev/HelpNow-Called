using HelpNow.Called.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpNow.Called.Infrastructure.UoW;
using HelpNow.Called.Domain.Dtos;
using Dapper;
using HelpNow.Called.Domain.Models;

namespace HelpNow.Called.Infrastructure.Repository;
public class CalledRepository(IUnitOfWork uow) : ICalledRepository
{
    private readonly IUnitOfWork _uow = uow;

    public async Task AdicionarChamadoAsync(CalledModel called)
    {
        var query = @"INSERT INTO TbChamados (Titulo, Descricao, SolicitanteId, Status, DtCriacao)
                      VALUES (@Titulo, @Descricao, @SolicitanteId, @Status, @DtCriacao)";

        await _uow.Connection.ExecuteAsync(query, called, _uow.Transaction);
    }

}
