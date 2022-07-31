 using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MaestroDetalle.Models;
using System.Xml.Linq;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MaestroDetalle.Controllers
{
    public class HomeController : Controller
    {
        private readonly string cadenaSQL;

        public HomeController(IConfiguration config)
        {
            cadenaSQL = config.GetConnectionString("CadenaSQL");
        }
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

            using (SqlConnection conexion = new SqlConnection(cadenaSQL))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_guardarVenta", conexion);
                cmd.Parameters.Add("venta_xml", SqlDbType.Xml).Value = venta.ToString();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
            }

            return Json(new { respuesta = true });
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
