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
    
    public partial class vwcaj_MovCaja_x_Cobro_Anticipo
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipocbte { get; set; }
        public Nullable<int> IdBanco { get; set; }
        public int IdCaja { get; set; }
        public string IdCtaCble_TipoCobro { get; set; }
        public string IdCtaCble_ban { get; set; }
        public decimal IdCobro { get; set; }
        public string IdCobro_tipo { get; set; }
        public double cr_TotalCobro { get; set; }
        public Nullable<int> Documento_Cobrado { get; set; }
        public string nCliente { get; set; }
        public string nSucursal { get; set; }
        public int IdPeriodo_Caja { get; set; }
        public System.DateTime cr_fecha { get; set; }
        public System.DateTime cr_fechaDocu { get; set; }
        public string cr_NumDocumento { get; set; }
        public double Expr1 { get; set; }
        public double cm_valor { get; set; }
    }
}
