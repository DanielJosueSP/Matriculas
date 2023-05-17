using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Gestion.Models;
using System.Linq;

namespace Gestion.Controllers;

    public class HomeController : Controller
    {
        private RegistroNota _context;

        public HomeController(RegistroNota c){
            _context = c;
        }
        public IActionResult Index(){
            var notas = _context.Notas.ToList();

            return View(notas);

        }

        public IActionResult Registro(){
            return View();
        }
        [HttpPost]
        public IActionResult Registro(Alumno n){
            if (ModelState.IsValid)
            {
                n.calcularPromedio();
                _context.Add(n);
                _context.SaveChanges();
                return RedirectToAction("index");

            }else{
                return View(n);
            }


        }

    }

