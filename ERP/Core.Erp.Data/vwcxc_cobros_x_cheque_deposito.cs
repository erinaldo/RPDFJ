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
    
    public partial class vwcxc_cobros_x_cheque_deposito
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string Sucursal { get; set; }
        public decimal IdCobro { get; set; }
        public decimal IdCliente { get; set; }
        public string IdCobro_tipo { get; set; }
        public string TipoCobro { get; set; }
        public string IdEstadoCobro { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.DateTime FechaCobro { get; set; }
        public string Banco_del_cheq { get; set; }
        public string Cuenta { get; set; }
        public string Num_Cheq { get; set; }
        public double TotalCobro { get; set; }
        public Nullable<decimal> mcj_IdCbteCble { get; set; }
        public Nullable<int> mcj_IdTipocbte { get; set; }
        public Nullable<int> IdCaja { get; set; }
        public string CodCaja { get; set; }
        public Nullable<decimal> ba_IdCbteCble { get; set; }
        public Nullable<int> ba_IdTipocbte { get; set; }
        public Nullable<System.DateTime> Fecha_dep { get; set; }
        public Nullable<int> IdBanco_dep { get; set; }
        public string Banco_deposito { get; set; }
        public string Cliente { get; set; }
        public string Referencia { get; set; }
    }
}
