//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Compras_Edehsa
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwcom_ListadoElementos_x_OT_Detalle
    {
        public int IdEmpresa { get; set; }
        public string CodObra { get; set; }
        public decimal IdOrdenTaller { get; set; }
        public decimal IdListadoElementos_x_OT { get; set; }
        public int IdDetalle { get; set; }
        public decimal IdProducto { get; set; }
        public double Unidades { get; set; }
        public double Det_Kg { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public string IdEstadoAprob { get; set; }
        public System.DateTime FechaReg { get; set; }
        public string Estado { get; set; }
        public string lm_Observacion { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
        public string IdCategoria { get; set; }
        public double longitud { get; set; }
        public Nullable<double> pr_largo { get; set; }
        public Nullable<double> largo_total { get; set; }
        public Nullable<double> largo_restante { get; set; }
        public Nullable<double> largo_pieza_entera { get; set; }
        public Nullable<int> cantidad_pieza_entera { get; set; }
        public Nullable<double> largo_pieza_complementaria { get; set; }
        public Nullable<double> cantidad_pieza_complementaria { get; set; }
        public Nullable<double> cantidad_total_pieza_complementaria { get; set; }
        public Nullable<double> largo_despunte1 { get; set; }
        public Nullable<bool> es_despunte_usable1 { get; set; }
        public Nullable<double> cantidad_despunte1 { get; set; }
        public Nullable<double> largo_despunte2 { get; set; }
        public Nullable<double> cantidad_despunte2 { get; set; }
        public Nullable<bool> es_despunte_usable2 { get; set; }
    }
}
