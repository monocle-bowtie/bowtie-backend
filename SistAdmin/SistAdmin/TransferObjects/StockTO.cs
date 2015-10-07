using SistAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistAdmin.TransferObjects
{
	public class StockTO : Stock
	{
        public int id { get; set; }
        public int idProducto { get; set; }
        public int Cantidad { get; set; }
        public char Estado   { get; set; }
        public decimal PrecioCosto { get; set; }
	}
}