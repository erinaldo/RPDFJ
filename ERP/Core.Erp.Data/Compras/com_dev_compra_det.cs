//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Compras
{
    using System;
    using System.Collections.Generic;
    
    public partial class com_dev_compra_det
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdDevCompra { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double dv_Cantidad { get; set; }
        public double dv_precioCompra { get; set; }
        public double dv_porc_des { get; set; }
        public double dv_descuento { get; set; }
        public double dv_subtotal { get; set; }
        public double dv_iva { get; set; }
        public double dv_total { get; set; }
        public string dv_ManejaIva { get; set; }
        public string dv_Costeado { get; set; }
        public double dv_peso { get; set; }
        public string dv_observacion { get; set; }
        public Nullable<int> ocdet_IdEmpresa { get; set; }
        public Nullable<int> ocdet_IdSucursal { get; set; }
        public Nullable<decimal> ocdet_IdOrdenCompra { get; set; }
        public Nullable<int> ocdet_Secuencia { get; set; }
    
        public virtual com_dev_compra com_dev_compra { get; set; }
    }
}