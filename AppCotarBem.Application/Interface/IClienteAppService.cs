using AppCotarBem.Domain.Entities;
using System.Collections.Generic;

namespace AppCotarBem.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}