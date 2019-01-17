﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StartupDemo.Controllers
{
    public class TesteController : Controller
    {
		[Route("")]
		//[Route("dashboard/tela-inicial")]
		//[Route("dashboard/tela-inicial/{int:id}/{valor: guid}")]
		public IActionResult Index(int id, Guid valor)
        {
			//return View();
			//return Json("{'Nome': 'Geovane'}");
			return RedirectToAction("Teste");
        }

		public IActionResult Teste()
		{
			return View("Index");
		}
    }
}
