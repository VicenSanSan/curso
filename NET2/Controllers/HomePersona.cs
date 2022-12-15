using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NET2.Models;

namespace NET2.Controllers;

public class PersonaController : Controller
{
    private readonly ILogger<PersonaController> _logger;

    public PersonaController(ILogger<PersonaController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        PersonaRepository repositorio= new PersonaRepository();
        List<Persona> lista= repositorio.BuscarTodas();
        ViewBag.lista=lista;

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
