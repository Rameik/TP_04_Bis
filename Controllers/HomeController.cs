using Microsoft.AspNetCore.Mvc;
using TP_04_Bis.Models;

namespace TP_04_Bis.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaPaises = Info.listarPaises();
        return View();
    }

    public IActionResult DetallePais(int idPais)
    {
        ViewBag.Pais = Info.detallePais(idPais);
        return View();
    }
}
