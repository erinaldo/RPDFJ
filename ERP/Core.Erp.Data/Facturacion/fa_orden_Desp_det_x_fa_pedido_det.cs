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
    
    public partial class fa_orden_Desp_det_x_fa_pedido_det
    {
        public int od_IdEmpresa { get; set; }
        public int od_IdSucursal { get; set; }
        public int od_IdBodega { get; set; }
        public decimal od_IdOrdenDespacho { get; set; }
        public int od_Secuencia { get; set; }
        public decimal od_IdProducto { get; set; }
        public double od_cantidad { get; set; }
        public int pe_IdEmpresa { get; set; }
        public int pe_IdSucursal { get; set; }
        public int pe_IdBodega { get; set; }
        public decimal pe_IdPedido { get; set; }
        public int pe_Secuencia { get; set; }
        public decimal pe_IdProducto { get; set; }
    
        public virtual fa_orden_Desp_det fa_orden_Desp_det { get; set; }
        public virtual fa_pedido_det fa_pedido_det { get; set; }
    }
}
