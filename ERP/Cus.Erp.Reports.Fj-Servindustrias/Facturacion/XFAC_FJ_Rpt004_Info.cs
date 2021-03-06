﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt004_Info
    {
        public long IdRow { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdPreFacturacion { get; set; }
        public int Secuencia { get; set; }
        public int eg_IdEmpresa { get; set; }
        public int eg_IdSucursal { get; set; }
        public int eg_IdMovi_inven_tipo { get; set; }
        public decimal eg_IdNumMovi { get; set; }
        public int eg_Secuencia { get; set; }
        public double eg_cantidad { get; set; }
        public System.DateTime eg_fecha { get; set; }
        public string eg_codigo { get; set; }
        public Nullable<int> in_IdEmpresa { get; set; }
        public Nullable<int> in_IdSucursal { get; set; }
        public Nullable<int> in_IdMovi_inven_tipo { get; set; }
        public Nullable<decimal> in_IdNumMovi { get; set; }
        public Nullable<int> in_Secuencia { get; set; }
        public double in_cantidad { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public Nullable<System.DateTime> cp_fecha { get; set; }
        public string cp_numero { get; set; }
        public int IdActivoFijo { get; set; }
        public double costo_uni { get; set; }
        public double subtotal { get; set; }
        public decimal IdProducto { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string nom_punto_cargo { get; set; }
        public string Centro_costo { get; set; }
    }
}
