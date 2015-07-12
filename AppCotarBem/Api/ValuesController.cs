using AppCotarBem.Domain.Entities;
using AppCotarBem.Infra.Data.Repositories;
using AppCotarBem.ViewModels;
using AutoMapper;
using System.Collections.Generic;
using System.Web.Http;

namespace AppCotarBem.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        private readonly ClienteRepository _clienteRepository = new ClienteRepository();
        // GET: Clientes
        public IEnumerable<ClienteViewModel> Get()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteRepository.GetAll());
            //return View(clienteViewModel);
            return clienteViewModel;
        }

        //// GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
