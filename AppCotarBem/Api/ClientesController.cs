using AppCotarBem.Application.Interface;
using AppCotarBem.Domain.Entities;
using AppCotarBem.ViewModels;
using AutoMapper;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace AppCotarBem.Api
{
    public class ClientesController : ApiController
    {
        private readonly IClienteAppService _clienteAppService;

        public ClientesController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }

        // GET api/clientes
        public JsonResult<IEnumerable<ClienteViewModel>> Get()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteAppService.GetAll());
            return Json(clienteViewModel);
        }

        public void Post([FromBody]ClienteViewModel clienteViewModel)
        {
            var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);
            _clienteAppService.Add(clienteDomain);
        }

        public void Delete(int id)
        {
            var cliente = _clienteAppService.GetById(id);
            _clienteAppService.Remove(cliente);
        }
    }
}
