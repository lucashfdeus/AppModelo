using LH.UI.Site.Areas.Produtos.Data;
using Microsoft.AspNetCore.Mvc;

namespace LH.UI.Site.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    [Route("produtos")]
    public class ProdutosController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutosController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult Index()
        {
            var produto = _produtoRepository.ObterProduto();
            return View();
        }
    }
}
