using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EnqueteWeb.Models;

namespace EnqueteWeb.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Responder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Responder(Resposta form)
        {
            if (ModelState.IsValid)
            {
                Repositorio.AdicionarRespostas(form);
            // return Content("Sua resposta foi encaminhada com sucesso!");
                return View("Obrigado");
            }else{
                return View(form);
            }
            
            
        }

        public IActionResult Resultado(){
            return View(Repositorio.Respostas);
        }
    }
}
