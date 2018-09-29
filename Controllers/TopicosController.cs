using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Jeffao_Web.Controllers
{
    public class TopicosController : Controller
    {
        public IActionResult Index(string categoria, string topico)
        {
            return View();
        }
    }
}