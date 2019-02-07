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

        public Produto ObterProdutoPorId(int id)
        {
            return this.myWebAppContext.Produtos.SingleOrDefault(x => x.Id == id);
        }

        public List<Produto> Produtos()
        {
            return myWebAppContext.Produtos.ToList();
        }

        public void Salvar(Produto produto)
        {
            myWebAppContext.Produtos.Add(produto);
            myWebAppContext.SaveChanges();
        }
    }
}
