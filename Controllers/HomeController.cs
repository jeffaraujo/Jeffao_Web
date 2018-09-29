using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jeffao_Web.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            //Trabalhando com envio de variáveis / objetos
            ViewBag.Nome = "Jefão";
            ViewData["Nome"] = "Jefão ViewData";

            //Retornando a View com o nome do método
            return View();
            //Retornando uma View Específica
            //return View("OutraView");
        }

        public IActionResult Ajuda()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }



    }
}
