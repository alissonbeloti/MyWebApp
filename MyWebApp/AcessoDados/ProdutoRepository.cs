using MyWebApp.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MyWebApp.AcessoDados
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MyWebAppContext myWebAppContext;

        public ProdutoRepository(MyWebAppContext context)
        {
            this.myWebAppContext = context;
        }

        public List<Produto> Produtos()
        {
            return myWebAppContext.Produtos.ToList();
        }
    }
}
