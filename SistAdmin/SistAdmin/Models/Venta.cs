//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        public Venta()
        {
            this.VentaDetalle = new HashSet<VentaDetalle>();
        }
    
        public int idVenta { get; set; }
        public int idVendedor { get; set; }
        public int idCliente { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Estado { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public int UsuarioAlta { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public Nullable<int> UsuarioBaja { get; set; }
        public int idMedioPago { get; set; }
        public int idSucursal { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual MedioPago MedioPago { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public virtual Vendedor Vendedor { get; set; }
        public virtual ICollection<VentaDetalle> VentaDetalle { get; set; }
    }
}
