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
    
    public partial class fa_tarifario_horometro
    {
        public fa_tarifario_horometro()
        {
            this.fa_tarifario_horometro_det = new HashSet<fa_tarifario_horometro_det>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdTarifario { get; set; }
        public string IdCentroCosto { get; set; }
        public string Observacion { get; set; }
        public bool estado { get; set; }
        public decimal IdProducto_hora_regular { get; set; }
        public decimal IdProducto_hora_extra { get; set; }
        public int IdPeriodo_ini { get; set; }
        public int IdPeriodo_fin { get; set; }
        public string IdCod_Impuesto { get; set; }
        public double porcentaje { get; set; }
    
        public virtual ICollection<fa_tarifario_horometro_det> fa_tarifario_horometro_det { get; set; }
    }
}
