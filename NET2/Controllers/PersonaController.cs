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
        PersonaRepository repositorio = new PersonaRepository();
        List<Persona> lista = repositorio.BuscarTodas();
        ViewBag.lista = lista;

        return View();

    }

    public IActionResult FormularioInsertar()
    {
        return View();
    }


    public IActionResult Insertar(Persona persona)

    {
        PersonaRepository repositorio = new PersonaRepository();
        repositorio.Insertar(persona);
        List<Persona> lista = repositorio.BuscarTodas();
        ViewBag.lista = lista;

        return View("Index");
    }

    public IActionResult Borrar(String dni)

    {
        PersonaRepository repositorio = new PersonaRepository();
        repositorio.Borrar(new Persona(dni));
        List<Persona> lista = repositorio.BuscarTodas();
        ViewBag.lista = lista;

        return View("Index");
    }

public IActionResult Guardar(Persona persona)

    {
        PersonaRepository repositorio = new PersonaRepository();
        repositorio.Guardar(persona);
        List<Persona> lista = repositorio.BuscarTodas();
        ViewBag.lista = lista;

        return View("Index");
    }

public IActionResult Ordenar(string ordenar)

    {
        PersonaRepository repositorio = new PersonaRepository();
        
               return View("Index");
    }



    public IActionResult FormularioEditar(String dni)
    {
        {
            PersonaRepository repositorio = new PersonaRepository();
            Persona p = repositorio.BuscarUna(dni);
            ViewBag.persona = p;
            return View();
        }

    }
   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
