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
        
        return View("Habitacion1");
    }


    public IActionResult Habitacion(int sala, string clave)
    {
        int num = Escape.GetEstadoJuego();
        bool respuestaCorrecta = Escape.ResolverSala(sala, clave);
        if(respuestaCorrecta==true){
        num = Escape.GetEstadoJuego();
        }
        string salaAIr="dd";
        switch (num){
            case 0:
            salaAIr = "Habitacion1";
            break;
            case 1:
            salaAIr = "Habitacion2";
            break;
            case 2:
            salaAIr = "Habitacion3";
            break;
            case 3:
            salaAIr ="Habitacion4";
            break;
            case 4:
            salaAIr="HabitacionFinal";
            break;
        }
        return View(salaAIr);
    }


     public IActionResult Creditos(int sala, string clave)
    {
        return View();
    }
}
