using CapaEntidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;
using WebAppAdmMvc.Models;
using WebAppAdmMvc.Servicios.Contrato;

namespace WebAppAdmMvc.Controllers
{
    public class CatalogoController : Controller
    {


        private readonly ILogger<CatalogoController> _logger;
        private readonly ICatalogo _CatService;

        public CatalogoController(ILogger<CatalogoController> logger, ICatalogo CatalogoServicio)
        {
            _logger = logger;
            _CatService = CatalogoServicio;
        }



        // GET: CatalogoController
        public ActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult>  CargarLista()
        {
            List<tblCatalogo> usuariolista = new List<tblCatalogo>();
            List<vmCatalogo> model = new List<vmCatalogo>();
            try
            {
                usuariolista = await _CatService.GetCatalogoLista();

                model = usuariolista.Select(x => new vmCatalogo
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Edad = x.Edad,
                    Color = x.Color,
                    //Raza = x.Raza,
                    Fierro = x.Fierro,
                    Arete = x.Arete,
                    FechaNacimiento = x.FechaNacimiento,
                    Activo = x.Activo,
                    Clasificacion = x.Clasificacion,
                }).ToList();
                return Json(new { data = model });

            }

            catch (Exception ex)
            {
                return Json(new { succes = false }, new { data = model });
            }
          
        }


        // POST: CatalogoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CatalogoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CatalogoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CatalogoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CatalogoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
