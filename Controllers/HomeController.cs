using Jeffao_Web.Data;
using Jeffao_Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jeffao_Web.Controllers
{
    public class HomeController: Controller
    {

        private PerguntasContext _context;

        //Usando o EF no controler (Não é uma boa prática)
        public HomeController(PerguntasContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //Trabalhando com os dados do EF (Lista de Perguntas)
            var perguntas = _context.Perguntas.ToList();
            return View(perguntas);
        }




        //public IActionResult Index()
        //{
        //    //Trabalhando com envio de variáveis / objetos
        //    ViewBag.Nome = "Jefão";
        //    ViewData["Nome"] = "Jefão ViewData";


        //    //Tipificando a View usando um objeto (Model)
        //    var pergunta = new Pergunta() { ID = 1, Autor = "Jefão", Descricao = "La Pergunta?" };


        //    return View(pergunta);
        //    //Retornando a View com o nome do método
        //    //return View();
        //    //Retornando uma View Específica
        //    //return View("OutraView");
        //}


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> Create(Pergunta pergunta)
        {
            if(ModelState.IsValid)
            {
                _context.Perguntas.Add(pergunta);
                await _context.SaveChangesAsync(); //Assincrona
            }
            return View();
        }

        ////Usando uma forma não tipada para capturar valores no Formulário
        //[HttpPost]
        //public IActionResult Create(IFormCollection collection)
        //{
        //    var des = collection["Descricao"];
        //    var aut = collection["Autor"];

        //    return View();
        //}


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
