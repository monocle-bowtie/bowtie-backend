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
    
    public partial class MedioPago
    {
        public MedioPago()
        {
            this.Venta = new HashSet<Venta>();
        }
    
        public int idMedioPago { get; set; }
        public string Descripción { get; set; }
        public Nullable<decimal> RecargoAdicional { get; set; }
        public string Estado { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public int UsuarioAlta { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public Nullable<int> UsuarioBaja { get; set; }
        public Nullable<int> Lote { get; set; }
        public string Comprobante { get; set; }
    
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
