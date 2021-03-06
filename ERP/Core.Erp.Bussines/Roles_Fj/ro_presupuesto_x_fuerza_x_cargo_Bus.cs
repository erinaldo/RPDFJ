﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.Roles_Fj;
using Core.Erp.Info.Roles_Fj;
using Core.Erp.Info.General;
using Core.Erp.Data.General;
using Core.Erp.Data.Roles_Fj;
namespace Core.Erp.Business.Roles_Fj
{
  public  class ro_presupuesto_x_fuerza_x_cargo_Bus
  {
      string mensaje = "";

      ro_presupuesto_x_fuerza_x_cargo_Data dataP = new ro_presupuesto_x_fuerza_x_cargo_Data();
      public Boolean GrabarBD(ro_presupuesto_x_fuerza_x_cargo_Info info, ref string msg)
      {
          try
          {
              return dataP.GrabarBD(info, ref msg);
          }
          catch (Exception ex)
          {

              mensaje = ex.ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(mensaje);
          }
      }


      public List<ro_presupuesto_x_fuerza_x_cargo_Info> GetPresupuesto(int IdEmpresa, int idnomina, int anio, int mes)
      {
          try
          {
              return dataP.GetPresupuesto(IdEmpresa, idnomina, anio, mes);
          }
          catch (Exception ex)
          {

              mensaje = ex.ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(mensaje);
          }
      }
      public List<ro_presupuesto_x_fuerza_x_cargo_Info> GetPresupuesto(int IdEmpresa, int anio, int mes)
      {
          try
          {
              return dataP.GetPresupuesto(IdEmpresa,anio,mes);
          }
          catch (Exception ex)
          {

              mensaje = ex.ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", mensaje, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              throw new Exception(mensaje);
          }
      }
    }
}
