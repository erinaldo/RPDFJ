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
    
    public partial class ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito
    {
        public int mcj_IdEmpresa { get; set; }
        public decimal mcj_IdCbteCble { get; set; }
        public int mcj_IdTipocbte { get; set; }
        public int mba_IdEmpresa { get; set; }
        public decimal mba_IdCbteCble { get; set; }
        public int mba_IdTipocbte { get; set; }
        public int mcj_Secuencia { get; set; }
        public string Observacion { get; set; }
    
        public virtual ba_Cbte_Ban ba_Cbte_Ban { get; set; }
    }
}