﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Core.Erp.Business.General;
using System.Collections.Generic;

namespace Cus.Erp.Reports.FJ.Inventario
{
    public partial class XINV_FJ_Rpt006_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        public XINV_FJ_Rpt006_Rpt()
        {
            InitializeComponent();
            xlbl_idReporte.Text = "XINV_FJ_Rpt006_Rpt";
        }
       

        private void XINV_FJ_Rpt006_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrLUsuario.Text = param.IdUsuario;
                lblFechaImpresion.Text = DateTime.Now.ToString("dddd, dd' de 'MMMM' de 'yyyy HH:mm:ss");

                XINV_FJ_Rpt006_Bus BUS = new XINV_FJ_Rpt006_Bus();

                List<XINV_FJ_Rpt006_Info> ListDataRpt = new List<XINV_FJ_Rpt006_Info>();

                DateTime FechaIni;
                DateTime FechaFin;
                int IdSucursalIni = 0;
                int IdSucursalFin = 0;
                int IdBodegaIni = 0;
                int IdBodegaFin = 0;
                decimal IdProductoIni = 0;
                decimal IdProductoFin = 0;
                string IdCentroCosto = string.Empty;
                string IdSubCentroCosto = string.Empty;
                int IdMovi_inven_tipoIni = 0;
                int IdMovi_inven_tipoFin = 0;
                string TipoMov = string.Empty;
                //string nomtipomov = string.Empty;

                FechaIni = Convert.ToDateTime(Parameters["FechaIni"].Value);
                FechaFin = Convert.ToDateTime(Parameters["FechaFin"].Value);
                IdSucursalIni = Convert.ToInt32(Parameters["IdSucursalIni"].Value);
                IdSucursalFin = Convert.ToInt32(Parameters["IdSucursalFin"].Value);
                IdBodegaIni = Convert.ToInt32(Parameters["IdBodegaIni"].Value);
                IdBodegaFin = Convert.ToInt32(Parameters["IdBodegaFin"].Value);
                IdProductoIni = Convert.ToDecimal(Parameters["IdProductoIni"].Value);
                IdProductoFin = Convert.ToDecimal(Parameters["IdProductoFin"].Value);
                IdCentroCosto = (Parameters["IdCentro_costo"].Value).ToString();
                IdSubCentroCosto = (Parameters["IdSubcentro_costo"].Value).ToString();
                IdMovi_inven_tipoIni = Convert.ToInt32(Parameters["IdMovi_inven_tipoIni"].Value);
                IdMovi_inven_tipoFin = Convert.ToInt32(Parameters["IdMovi_inven_tipoFin"].Value);
                TipoMov = (Parameters["TipoMovimiento"].Value).ToString();

                lblFechaInicio.Text = FechaIni.ToShortDateString();
                lblFechaFin.Text = FechaFin.ToShortDateString();


                ListDataRpt = BUS.Get_Kardes_Movimiento(param.IdEmpresa, IdSucursalIni, IdSucursalFin, IdBodegaIni, IdBodegaFin, IdProductoIni, IdProductoFin, IdCentroCosto, IdSubCentroCosto, IdMovi_inven_tipoIni, IdMovi_inven_tipoFin, TipoMov, FechaIni, FechaFin);

                this.DataSource = ListDataRpt;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XINV_FJ_Rpt006_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XINV_FJ_Rpt006_Rpt) };
            }
        }

    }
}
