
using AppCotarBem.Domain.Entities;
using AppCotarBem.Domain.Services;
using System.Collections.Generic;

namespace AppCotarBem.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
