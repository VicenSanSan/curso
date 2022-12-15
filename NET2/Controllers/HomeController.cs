using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NET2.Models;

namespace NET2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Mensaje = "Hola amigos";
        ViewBag.Nombre = "Miguel";
        ViewBag.Edad = 20;
        
        List<String> lista1 = new List<string>();
        lista1.Add("hola");
        lista1.Add("que");
        lista1.Add("tal");
        lista1.Add("estás");
        ViewBag.lista1 = lista1;

        Persona p = new Persona("1", "maria", "gómez");
        Persona p2 = new Persona("2", "Miguel", "Sánchez");
        List<Persona> lista2=new List<Persona>();
        lista2.Add(p);
        lista2.Add(p2);
        ViewBag.Persona = p;
        ViewBag.lista2=lista2;
        return View();
    
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
