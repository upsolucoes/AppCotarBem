using AppCotarBem.Domain.Entities;
using System.Collections.Generic;

namespace AppCotarBem.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}