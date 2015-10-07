using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistAdmin.TransferObjects
{
	public class ProductoEntryTO
	{
		public int id { get; set; }
		public string Nombre { get; set; }
        public decimal Precio { get; set; }
		public int idProveedor { get; set; }
		public string CodigoBarras { get; set; }
		public char Estado { get; set; }
	}
}