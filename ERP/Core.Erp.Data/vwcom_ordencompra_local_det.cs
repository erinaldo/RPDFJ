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
    
    public partial class vwcom_ordencompra_local_det
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double do_Cantidad { get; set; }
        public double do_precioCompra { get; set; }
        public double do_porc_des { get; set; }
        public double do_descuento { get; set; }
        public double do_precioFinal { get; set; }
        public double do_subtotal { get; set; }
        public double do_iva { get; set; }
        public double do_total { get; set; }
        public bool do_ManejaIva { get; set; }
        public string do_Costeado { get; set; }
        public double do_peso { get; set; }
        public string do_observacion { get; set; }
        public string Tiene_Movi_Inven { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo_grupo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string IdUnidadMedida { get; set; }
        public string nom_sub_centro_costo { get; set; }
        public System.DateTime oc_fecha { get; set; }
        public string oc_observacion { get; set; }
        public string Su_Descripcion { get; set; }
        public Nullable<int> IdMotivo { get; set; }
        public string nom_motivo_OC { get; set; }
        public string pr_descripcion { get; set; }
        public string nom_medida { get; set; }
        public string IdUnidadMedida_Consumo { get; set; }
        public double Por_Iva { get; set; }
        public string IdCod_Impuesto { get; set; }
    }
}