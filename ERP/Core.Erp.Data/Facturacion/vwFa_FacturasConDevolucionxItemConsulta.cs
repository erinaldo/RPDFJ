//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Facturacion
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwFa_FacturasConDevolucionxItemConsulta
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public Nullable<decimal> IdDevolucion { get; set; }
        public decimal IdProducto { get; set; }
        public double vt_cantidad { get; set; }
        public double dv_cantidad { get; set; }
        public double dv_saldo { get; set; }
        public string vt_tieneIVA { get; set; }
        public double vt_PorDescUnitario { get; set; }
        public double vt_DescUnitario { get; set; }
        public double vt_iva { get; set; }
        public double vt_PrecioFinal { get; set; }
        public double vt_Precio { get; set; }
        public int Expr1 { get; set; }
        public string Estado { get; set; }
        public Nullable<double> dv_seguro { get; set; }
        public Nullable<double> dv_flete { get; set; }
        public Nullable<double> dv_interes { get; set; }
        public Nullable<double> dv_OtroValor1 { get; set; }
        public Nullable<double> dv_OtroValor2 { get; set; }
    }
}
