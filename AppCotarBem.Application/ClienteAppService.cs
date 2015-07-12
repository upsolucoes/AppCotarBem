using AppCotarBem.Application.Interface;
using AppCotarBem.Domain.Entities;
using AppCotarBem.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace AppCotarBem.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
    }
}