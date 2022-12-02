using Microsoft.AspNetCore.Mvc;

namespace LH.UI.Site.Areas.Produtos.Controllers
{
    [Area("Produtos")]
    [Route("produtos")]
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
