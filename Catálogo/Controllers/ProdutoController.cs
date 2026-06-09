using Microsoft.AspNetCore.Mvc;
using Catálogo.Models;

namespace Catálogo.Controllers;

public class ProdutoController : Controller {

    public IActionResult Index()
    {
        var Produto = new List<string> { "LuckStrike", "Malboro", "Gift", "Eight", "Camel" };
    var Preco = new List<double> { 6.00, 8.00, 4.00, 6.00, 12.00 };

    ViewBag.Produto = Produto;
    ViewBag.Preco = Preco;

    return View();
    }
}