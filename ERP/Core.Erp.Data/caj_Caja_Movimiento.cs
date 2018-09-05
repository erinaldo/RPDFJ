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
    
    public partial class caj_Caja_Movimiento
    {
        public caj_Caja_Movimiento()
        {
            this.caj_Caja_Movimiento_det = new HashSet<caj_Caja_Movimiento_det>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipocbte { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public string CodMoviCaja { get; set; }
        public string cm_Signo { get; set; }
        public string cm_beneficiario { get; set; }
        public double cm_valor { get; set; }
        public int IdTipoMovi { get; set; }
        public string cm_observacion { get; set; }
        public int IdCaja { get; set; }
        public int IdPeriodo { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuario_Anu { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public System.DateTime Fecha_Transac { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public string Estado { get; set; }
        public string MotivoAnulacion { get; set; }
        public string IdUsuario_Aprueba { get; set; }
        public Nullable<decimal> IdCbteCble_Anu { get; set; }
        public Nullable<int> IdTipocbte_Anu { get; set; }
        public Nullable<decimal> IdTipoFlujo { get; set; }
        public string IdTipo_Persona { get; set; }
        public Nullable<decimal> IdEntidad { get; set; }
        public Nullable<decimal> IdPersona { get; set; }
        public Nullable<decimal> IdRecibo { get; set; }
        public Nullable<int> IdPuntoVta { get; set; }
    
        public virtual caj_Caja caj_Caja { get; set; }
        public virtual ICollection<caj_Caja_Movimiento_det> caj_Caja_Movimiento_det { get; set; }
        public virtual caj_Caja_Movimiento_Tipo caj_Caja_Movimiento_Tipo { get; set; }
    }
}