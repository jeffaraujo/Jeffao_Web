using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jeffao_Web.Controllers
{
    public class HomeController: Controller
    {
        public string Index()
        {
            return DateTime.Now.ToString();
        }

    }
}
