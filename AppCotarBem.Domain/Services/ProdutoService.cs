﻿using AppCotarBem.Domain.Entities;
using AppCotarBem.Domain.Interfaces.Repositories;
using AppCotarBem.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace AppCotarBem.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}