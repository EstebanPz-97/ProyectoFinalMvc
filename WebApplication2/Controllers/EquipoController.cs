using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Xml.Linq;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class EquipoController : Controller
    {
        private readonly EquipoServices equipoServices;
        public string mensaje { get; set; }
        public EquipoController(EquipoServices equipoServices)
        {
            this.equipoServices = equipoServices;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var equipos = await equipoServices.getAllEquipo();
            return View(equipos);
        }

        [HttpPost]
        public async Task<IActionResult> Crear(string name, string ciudad, string duenio)
        {
            var equipo = Equipo.Build(Guid.NewGuid(), name, ciudad, duenio);
            await this.equipoServices.Crear(equipo);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Editar(Guid id)
        {
            var equipo = await equipoServices.getEquipoById(id);
            return View(equipo);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Guid id, string name, string ciudad, string duenio)
        {
            if (id == null)
            {
                return NotFound();
            }
            var equipo = Equipo.Build(id, name, ciudad, duenio);

            await this.equipoServices.Editar(equipo);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Eliminar(Guid id)
        {
            var equipo = await equipoServices.getEquipoById(id);
            await this.equipoServices.Eliminar(equipo);
            return RedirectToAction(nameof(Index));
        }

        
    }
}
