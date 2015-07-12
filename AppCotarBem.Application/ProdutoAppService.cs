using AppCotarBem.Application.Interface;
using AppCotarBem.Domain.Entities;
using AppCotarBem.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace AppCotarBem.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}