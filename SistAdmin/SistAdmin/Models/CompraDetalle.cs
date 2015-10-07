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
    
    public partial class CompraDetalle
    {
        public int idCompra { get; set; }
        public int idCompraDetalle { get; set; }
        public int idProducto { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> PrecioUnitario { get; set; }
        public Nullable<decimal> PrecioTotal { get; set; }
        public string Estado { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public int UsuarioAlta { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public Nullable<int> UsuarioBaja { get; set; }
    
        public virtual Compra Compra { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
