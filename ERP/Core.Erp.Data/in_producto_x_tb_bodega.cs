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
    
    public partial class in_producto_x_tb_bodega
    {
        public in_producto_x_tb_bodega()
        {
            this.in_producto_x_tb_bodega_Costo_Historico = new HashSet<in_producto_x_tb_bodega_Costo_Historico>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdProducto { get; set; }
        public double pr_precio_publico { get; set; }
        public double pr_precio_mayor { get; set; }
        public double pr_precio_puerta { get; set; }
        public double pr_precio_minimo { get; set; }
        public double pr_Por_descuento { get; set; }
        public double pr_stock_maximo { get; set; }
        public double pr_stock_minimo { get; set; }
        public double pr_costo_fob { get; set; }
        public double pr_costo_CIF { get; set; }
        public double pr_costo_promedio { get; set; }
        public string IdCtaCble_Inven { get; set; }
        public string IdCtaCble_CosBaseIva { get; set; }
        public string IdCtaCble_CosBase0 { get; set; }
        public string IdCtaCble_VenIva { get; set; }
        public string IdCtaCble_Ven0 { get; set; }
        public string IdCtaCble_DesIva { get; set; }
        public string IdCtaCble_Des0 { get; set; }
        public string IdCtaCble_DevIva { get; set; }
        public string IdCtaCble_Dev0 { get; set; }
        public string Estado { get; set; }
        public string IdCtaCble_Costo { get; set; }
        public string IdCentro_Costo_Inventario { get; set; }
        public string IdCentro_Costo_Costo { get; set; }
        public string IdCtaCble_Gasto_x_cxp { get; set; }
        public string IdCentroCosto_x_Gasto_x_cxp { get; set; }
        public string IdCentroCosto_sub_centro_costo_inv { get; set; }
        public string IdCentroCosto_sub_centro_costo_cost { get; set; }
        public string IdCentroCosto_sub_centro_costo_cxp { get; set; }
        public string IdCtaCble_Vta { get; set; }
    
        public virtual ICollection<in_producto_x_tb_bodega_Costo_Historico> in_producto_x_tb_bodega_Costo_Historico { get; set; }
        public virtual in_Producto in_Producto { get; set; }
    }
}