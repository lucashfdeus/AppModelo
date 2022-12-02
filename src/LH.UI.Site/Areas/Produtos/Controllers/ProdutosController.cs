using Microsoft.AspNetCore.Mvc;

namespace LH.UI.Site.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
