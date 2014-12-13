using Final.DB;
using Final.Models;
using Final.ViewModels.Ventas;
using System.Web.Mvc;
using System.Linq;

namespace Final.Controllers
{
    public class VentaController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            var viewModel = CreateViewModel();
            return View("Create", viewModel);
        }
       

        [HttpPost]
        public ActionResult Create(CrearVentaViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var entities = new FinalEntities();
                entities.Ventas.Add(ConvertViewModelToVentaModel(viewModel));
                return RedirectToAction("Index");
            }
            return View("Create", viewModel);

        }

        private CrearVentaViewModel CreateViewModel()
        {
            var entities = new FinalEntities();
            return new CrearVentaViewModel
            {
                Clientes = entities.Clientes.Select(x => new CrearVentaClienteViewModel
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList()
            };

        }

        private static Venta ConvertViewModelToVentaModel(CrearVentaViewModel viewModel)
        {
            return new Venta
            {
                NumeroComprobante = viewModel.NumeroComprobante,
                FechaComprobante = viewModel.Fecha,
                ClienteId = viewModel.ClienteId

            };
        }
    }
}
