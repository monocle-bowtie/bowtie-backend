using System;
using System.Threading.Tasks;
using SistAdmin.Models;

namespace SistAdmin.TransferObjects
{
    public class VentaTO
	{

        public int id { get; set; }
        public int idVendedor { get; set; }
        public int idCliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public char Estado { get; set; }
        public int idMedioPago { get; set; }
        
    }
}
