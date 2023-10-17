using CapaDatos;
using CapaDatos.Servicios;
using CapaEntidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using WebAppAdmMvc.Models;
using WebAppAdmMvc.Servicios.Contrato;

namespace WebAppAdmMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ConexionSQL _dbContext;
        private readonly ICatalogo _CatService;

        public HomeController(ILogger<HomeController> logger, ConexionSQL dbContext , ICatalogo CatalogoServicio)
        {
            _logger = logger;
            _dbContext = dbContext;
            _CatService = CatalogoServicio;
        }

        public IActionResult Index()
        {
            //DataSet result = new DataSet();
            //result = _CatService.GetCatalogoTodo();

            return View();
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