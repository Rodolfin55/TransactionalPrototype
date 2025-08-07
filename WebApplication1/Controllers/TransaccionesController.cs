using Microsoft.AspNetCore.Mvc;
using TuProyecto.Models;
using System.Collections.Generic;
using System.Linq;

namespace TuProyecto.Controllers
{
    public class TransaccionesController : Controller
    {
        private static List<Transaccion> _transacciones = new List<Transaccion>(); // ← simulamos una base de datos

        public IActionResult Index()
        {
            return View(_transacciones.OrderByDescending(t => t.FechaTransaccion).ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Transaccion transaccion)
        {
            if (ModelState.IsValid)
            {
                transaccion.Id = _transacciones.Count + 1;
                _transacciones.Add(transaccion);
                TempData["Mensaje"] = "Transacción guardada exitosamente.";
                return RedirectToAction("Index");
            }

            return View(transaccion);
        }
    }
}
