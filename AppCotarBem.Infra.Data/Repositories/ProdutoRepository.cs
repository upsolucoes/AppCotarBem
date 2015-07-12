using AppCotarBem.Domain.Entities;
using AppCotarBem.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace AppCotarBem.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
