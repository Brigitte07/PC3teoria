using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PCteoria3.Data;
using PCteoria3.Models;

namespace PCteoria3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context=context;
        }

        public IActionResult Index()
        {
      
           
            
            
            var registro = _context.Registrar.ToList();
            

            return View(registro);
        }
          public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ingresar(Registrar objCliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(objCliente);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View("Regitrar", objCliente);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}