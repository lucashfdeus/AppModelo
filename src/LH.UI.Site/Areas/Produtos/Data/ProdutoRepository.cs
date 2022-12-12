using LH.UI.Site.Areas.Produtos.Models;

namespace LH.UI.Site.Areas.Produtos.Data
{
    public class ProdutoRepository : IProdutoRepository
    {
        public Produto ObterProduto()
        {
            return new Produto();
        }
    }

    public interface IProdutoRepository
    {
        Produto ObterProduto();
    }
}
