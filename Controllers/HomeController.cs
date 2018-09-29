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
