using AppCotarBem.Domain.Entities;
using System.Collections.Generic;

namespace AppCotarBem.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
