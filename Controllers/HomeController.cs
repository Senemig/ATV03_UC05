using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade3.Models;

namespace Atividade3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Serviços()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult SalvarMensagem(Mensagem m)
        {
            m.dataString = m.data.ToShortDateString();
            return View("ConfirmarMsg", m);
        }
    }
}
