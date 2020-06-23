using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class PagoProveedor
    {
        [Required]
        [Display(Name = "Número de Factura")]
        public string factura { get; set; }

        [Required]
        [Display(Name = "Proveedor")]
        public string proveedor { get; set; }

        [Required]
        [Display(Name = "Fecha de Pago")]
        public string fecha { get; set; }

        [Required]
        [Display(Name = "Total a Pagar")]
        public string total { get; set; }

        [Display(Name = "Favor de ingresar la cantidad a pagar")]
        public string mensajeCantidad { get; set; }
        
    }
}