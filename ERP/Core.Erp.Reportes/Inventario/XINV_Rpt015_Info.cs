﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.Inventario
{
    public class XINV_Rpt015_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public int IdBodega { get; set; }
        public string cod_bodega { get; set; }
        public string nom_bodega { get; set; }
        public string cod_sucursal { get; set; }
        public string nom_sucursal { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string cod_proveedor { get; set; }
        public string nom_proveedor { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string nom_subcentro { get; set; }
        public string nom_centro { get; set; }
        public string IdCentroCosto { get; set; }
        public string co_factura { get; set; }
        public Nullable<int> IdEmpresa_oc { get; set; }
        public Nullable<int> IdSucursal_oc { get; set; }
        public Nullable<decimal> IdOrdenCompra { get; set; }
        public Nullable<int> Secuencia_oc { get; set; }
        public string IdUnidadMedida_sinConversion { get; set; }
        public Nullable<double> dm_cantidad_sinConversion { get; set; }
        public Nullable<double> mv_costo_sinConversion { get; set; }
        public Nullable<double> Total_sinConversion { get; set; }
        public string IdUnidadMedida { get; set; }
        public Nullable<double> dm_cantidad { get; set; }
        public double mv_costo { get; set; }
        public Nullable<double> Total_convertido { get; set; }
        public string signo { get; set; }
        public string IdEstadoAproba { get; set; }
        public string cm_observacion { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public string Estado { get; set; }
        public string tm_descripcion { get; set; }
        public string Codigo { get; set; }
        public string cm_descripcionCorta { get; set; }
        public string nom_punto_cargo { get; set; }
        public XINV_Rpt015_Info()
       
        {
        }
    }
}
