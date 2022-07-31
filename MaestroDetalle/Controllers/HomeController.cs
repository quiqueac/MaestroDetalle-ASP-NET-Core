 using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MaestroDetalle.Models;
using System.Xml.Linq;

namespace MaestroDetalle.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GuardarVenta([FromBody] Venta body)
        {
            XElement venta = new XElement("Venta",
                new XElement("NumeroDocumento", body.NumeroDocumento),
                new XElement("RazonSocial", body.RazonSocial),
                new XElement("Total", body.Total)
                );

            XElement oDetalleVenta = new XElement("Detalle_Venta");

            foreach(DetalleVenta item in body.lstDetalleVenta)
            {
                oDetalleVenta.Add(new XElement("Item",
                    new XElement("Producto", item.Producto),
                    new XElement("Precio", item.Precio),
                    new XElement("Cantidad", item.Cantidad),
                    new XElement("Total", item.Total)
                    ));
            }

            venta.Add(oDetalleVenta);
            return Json(true);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
