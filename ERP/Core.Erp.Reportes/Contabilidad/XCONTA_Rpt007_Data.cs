﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Erp.Data.General;
using Core.Erp.Info.General;

namespace Core.Erp.Reportes.Contabilidad
{
    public class XCONTA_Rpt007_Data
    {
        string MensajeError = "";
        public List<XCONTA_Rpt007_Info> Get_List_Reporte(int IdEmpresa, DateTime FechaIni, DateTime FechaFin,string IdCentro_Costo
            ,int IdPunto_Cargo_Grupo,int IdPunto_Cargo, bool Mostrar_Cero,bool MostrarCC,string IdUsuario)
        {
            try
            {
                FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
                FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());

                List<XCONTA_Rpt007_Info> Lista = new List<XCONTA_Rpt007_Info>();

                using (EntitiesContabilidadRptGeneral context = new EntitiesContabilidadRptGeneral())
                {
                    context.SetCommandTimeOut(3000);

                    var contact = from q in context.spCON_Mayorizar_x_fecha_corte(IdEmpresa, FechaIni, FechaFin, IdCentro_Costo, IdPunto_Cargo_Grupo, IdPunto_Cargo, Mostrar_Cero,MostrarCC,true,IdUsuario)
                                  select q;

                    foreach (var item in contact)
                    {
                        XCONTA_Rpt007_Info Info = new XCONTA_Rpt007_Info();
                        Info.IdEmpresa = item.IdEmpresa;
                        Info.IdCtaCble = item.IdCtaCble;
                        Info.nom_cuenta = item.nom_cuenta;
                        Info.IdNivelCta = item.IdNivelCta;
                        Info.GrupoCble = item.GrupoCble;
                        Info.OrderGrupoCble = item.OrderGrupoCble;
                        Info.IdCtaCblePadre = item.IdCtaCblePadre;
                        Info.Saldo_Inicial = item.Saldo_Inicial;
                        Info.Debito_Mes = item.Debito_Mes;
                        Info.Credito_Mes = item.Credito_Mes;

                        Info.Saldo_inicial_x_Movi = item.Saldo_inicial_x_Movi;
                        Info.Debito_Mes_x_Movi = item.Debito_Mes_x_Movi;
                        Info.Credito_Mes_x_Movi = item.Credito_Mes_x_Movi;
                        Info.Saldo_x_Movi = item.Saldo_x_Movi;
                        
                        Info.Saldo = item.Saldo;
                        Info.pc_EsMovimiento = item.pc_EsMovimiento;



                        Info.IdPuntoCargo = item.IdPunto_cargo;
                        Info.IdPuntoCargo_Grupo = item.IdPunto_cargo_grupo;
                        Info.IdCentroCosto = item.IdCentroCosto;
                        Info.nom_PuntoCargo = item.nom_punto_cargo;
                        Info.nom_PuntoCargo_Grupo = item.nom_punto_cargo_grupo;
                        Info.nom_CentroCosto = item.nom_centro_costo;
                        Info.nom_empresa = item.nom_empresa;



                        Info.nom_empresa = item.nom_empresa;

                        Lista.Add(Info);
                    }
                }
                return Lista;
            }
            catch (Exception ex)
            {
                string arreglo = ToString();
               tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
               tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
               MensajeError = ex.ToString() + " " + ex.Message;
               oDataLog.Guardar_Log_Error(Log_Error_sis, ref MensajeError);
               throw new Exception(ex.InnerException.ToString());
           }
        }
    }
}
