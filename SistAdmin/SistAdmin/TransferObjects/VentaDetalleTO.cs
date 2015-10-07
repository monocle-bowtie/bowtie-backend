using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistAdmin.TransferObjects
{
	public class VentaDetalleTO
	{
        public int idVenta { get; set; }
        public int idVentaDetalle { get; set; }
        public int idProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PrecioFinal { get; set; }
        public char Estado { get; set; }

	}
}