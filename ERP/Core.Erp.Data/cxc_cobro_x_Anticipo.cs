//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class cxc_cobro_x_Anticipo
    {
        public cxc_cobro_x_Anticipo()
        {
            this.cxc_cobro_x_Anticipo_det = new HashSet<cxc_cobro_x_Anticipo_det>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdAnticipo { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCliente { get; set; }
        public string Observacion { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string MotiAnula { get; set; }
        public Nullable<int> IdCaja { get; set; }
    
        public virtual ICollection<cxc_cobro_x_Anticipo_det> cxc_cobro_x_Anticipo_det { get; set; }
    }
}
