using HelpNow.Called.Domain.Dtos;
using HelpNow.Called.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpNow.Called.Domain.Interfaces;
public interface ICalledRepository
{
    Task AdicionarChamadoAsync(CalledModel userModel);

}
