﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.Naturisa.CuentasxCobrar
{
    public class XCXC_NATU_Rpt001_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public string vt_tipoDoc { get; set; }
        public decimal IdCliente { get; set; }
        public decimal IdPersona { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string IdTipoDocumento { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_Naturaleza { get; set; }
        public string cod_parroquia { get; set; }
        public string nom_parroquia { get; set; }
        public string Cod_Ciudad { get; set; }
        public string Descripcion_Ciudad { get; set; }
        public string Cod_Provincia { get; set; }
        public string Descripcion_Prov { get; set; }
        public string pe_sexo { get; set; }
        public string nom_sexo { get; set; }
        public string IdEstadoCivil { get; set; }
        public string nom_EstadoCivil { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public Nullable<System.DateTime> vt_fecha_vcto { get; set; }
        public Nullable<System.DateTime> vt_fecha_exigible { get; set; }
        public int vt_plazo { get; set; }
        public string vt_tipo_venta { get; set; }
        public string nom_TerminoPago { get; set; }
        public int Num_Coutas { get; set; }
        public string num_factura { get; set; }
        public Nullable<double> Valor_operacion { get; set; }
        public Nullable<double> Saldo_operacion { get; set; }
        public Nullable<int> Dias_morosidad { get; set; }
        public Nullable<double> Monto_morosidad { get; set; }
        public int Monto_interes_mora { get; set; }
        public Nullable<double> x_vencer_0_30 { get; set; }
        public Nullable<double> x_vencer_31_90 { get; set; }
        public Nullable<double> x_vencer_91_180 { get; set; }
        public Nullable<double> x_vencer_181_360 { get; set; }
        public Nullable<double> x_vencer_mayor_360 { get; set; }
        public Nullable<double> vencido_0_30 { get; set; }
        public Nullable<double> vencido_31_90 { get; set; }
        public Nullable<double> vencido_91_180 { get; set; }
        public Nullable<double> vencido_181_360 { get; set; }
        public Nullable<double> vencido_mayor_360 { get; set; }
    }
}
