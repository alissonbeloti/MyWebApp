﻿using System.Collections.Generic;
using MyWebApp.Entities;

namespace MyWebApp.AcessoDados
{
    public interface IProdutoRepository
    {
        List<Produto> Produtos();
        Produto ObterProdutoPorId(int id);
        void Salvar(Produto produto);
    }
}