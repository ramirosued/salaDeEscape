using Microsoft.AspNetCore.Mvc;

namespace salaDeEscape.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

     public IActionResult Tutorial()
    {
        return View();
    }

     public IActionResult Comenzar()
    {
        int num = Escape.GetEstadoJuego();
        if(num==5){
        num=Escape.ReiniciarEstadoJuego();
        }
        return View("Habitacion"+num);

    }


    public IActionResult Habitacion(int sala, string clave)
    {
        
        int num = Escape.GetEstadoJuego();
        bool respuestaCorrecta = Escape.ResolverSala(sala, clave);
        if(respuestaCorrecta==true){
        num = Escape.GetEstadoJuego();
        }else{
            ViewBag.tuRespuesta="Respuesta Incorecta";
        }
        return View("Habitacion"+num);
    }


     public IActionResult Creditos(int sala, string clave)
    {
        return View();
    }
}
