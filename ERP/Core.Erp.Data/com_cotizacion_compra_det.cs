//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class com_cotizacion_compra_det
    {
        public int IdEmpresa { get; set; }
        public decimal IdCotizacion { get; set; }
        public int Secuencia { get; set; }
        public Nullable<decimal> Idproducto { get; set; }
        public Nullable<double> Cant_soli { get; set; }
        public Nullable<double> Cant_a_cotizar { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> IdEmpresa_lq { get; set; }
        public Nullable<decimal> IdListadoMateriales_lq { get; set; }
        public Nullable<int> IdDetalle_lq { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
    
        public virtual com_cotizacion_compra com_cotizacion_compra { get; set; }
        public virtual com_ListadoMateriales_Det com_ListadoMateriales_Det { get; set; }
    }
}