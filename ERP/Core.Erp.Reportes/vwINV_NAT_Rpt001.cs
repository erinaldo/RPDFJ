//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Reportes
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwINV_NAT_Rpt001
    {
        public int IdEmpresa { get; set; }
        public decimal IdGuia { get; set; }
        public string NumGuia { get; set; }
        public Nullable<int> IdSucursal_Partida { get; set; }
        public string sucursal_parti { get; set; }
        public Nullable<int> IdSucursal_Llegada { get; set; }
        public string sucursal_llegad { get; set; }
        public Nullable<decimal> IdTransportista { get; set; }
        public string Transportista { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> Fecha_Traslado { get; set; }
        public Nullable<System.DateTime> Fecha_llegada { get; set; }
        public string IdMotivo_Traslado { get; set; }
        public string Motivo_Traslado { get; set; }
        public string TipoDetalle { get; set; }
        public int secuencia { get; set; }
        public Nullable<decimal> IdOrdenCompra_OC { get; set; }
        public Nullable<int> Secuencia_OC { get; set; }
        public string observacion { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public string Nom_producto { get; set; }
        public Nullable<double> Cantidad_enviar { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string nom_proveedor { get; set; }
        public string Num_Fact { get; set; }
        public string Observacion_OC { get; set; }
    }
}
