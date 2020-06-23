using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ecommerce.Models;
using System.IO;
using Microsoft.AspNet.Identity;

namespace Ecommerce.Controllers
{
    public class PagoProveedorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: PagoProveedor
        public ActionResult InicioPagoProveedor()
        {
            return View();
        }

        // GET: PagoProveedor
        public ActionResult ConsultarFacturas()
        {
            return View();
        }

        // GET: PagoProveedor
        public ActionResult ConsultarFactura()
        {
            return View();
        }

        // GET: PagoProveedor
        public ActionResult GenerarOrdenPagoId4()
        {
            return View();
        }

        // GET: PagoProveedor
        public ActionResult GenerarOrdenPagoId5()
        {
            return View();
        }

        // GET: PagoProveedor
        public ActionResult GenerarOrdenPagoId6()
        {
            return View();
        }

        // GET: PagoProveedor
        public ActionResult VerDetallesId4()
        {
            return View();
        }

        // GET: PagoProveedor
        public ActionResult VerDetallesId5()
        {
            return View();
        }

        // GET: PagoProveedor
        public ActionResult VerDetallesId6()
        {
            return View();
        }

        // GET: PagoProveedor
        public ActionResult HistorialPagos()
        {
            return View();
        }

        
    }
}