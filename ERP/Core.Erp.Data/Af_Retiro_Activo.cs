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
    
    public partial class Af_Retiro_Activo
    {
        public int IdEmpresa { get; set; }
        public decimal IdRetiroActivo { get; set; }
        public string Cod_Ret_Activo { get; set; }
        public int IdActivoFijo { get; set; }
        public double ValorActivo { get; set; }
        public double Valor_Tot_Bajas { get; set; }
        public Nullable<double> Valor_Tot_Mejora { get; set; }
        public double Valor_Depre_Acu { get; set; }
        public double Valor_Neto { get; set; }
        public string NumComprobante { get; set; }
        public string Concepto_Retiro { get; set; }
        public System.DateTime Fecha_Retiro { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotivoAnula { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
    
        public virtual Af_Activo_fijo Af_Activo_fijo { get; set; }
    }
}
