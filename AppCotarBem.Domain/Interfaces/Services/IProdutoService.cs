using AppCotarBem.Domain.Entities;
using AppCotarBem.Domain.Services;
using System.Collections.Generic;

namespace AppCotarBem.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}