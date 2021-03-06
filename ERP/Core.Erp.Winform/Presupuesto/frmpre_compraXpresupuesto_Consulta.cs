﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.Erp.Business.CuentasxPagar;
using Core.Erp.Business.General;
using Core.Erp.Info.General;
using Core.Erp.Business.Presupuesto;
using Core.Erp.Info.Presupuesto;

namespace Core.Erp.Winform.Presupuesto
{
    public partial class frmpre_compraXpresupuesto_Consulta : Form
    {
        public frmpre_compraXpresupuesto_Consulta()
        {
            InitializeComponent();
            try
            {
                repositoryItemSearchLookUpEdit_prov.DataSource = proveedorB.Get_List_proveedor(param.IdEmpresa);
                loadData();
                ucGe_Menu_Mantenimiento_x_usuario.event_btnAnular_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnconsultar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnModificar_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnNuevo_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick;
                ucGe_Menu_Mantenimiento_x_usuario.event_btnSalir_ItemClick += ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        void ucGe_Menu_Mantenimiento_x_usuario_event_btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamaFrmMant(Cl_Enumeradores.eTipo_action.grabar, oc_I);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamaFrmMant(Cl_Enumeradores.eTipo_action.actualizar, oc_I);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnconsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamaFrmMant(Cl_Enumeradores.eTipo_action.consultar, oc_I);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void ucGe_Menu_Mantenimiento_x_usuario_event_btnAnular_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                llamaFrmMant(Cl_Enumeradores.eTipo_action.Anular, oc_I);
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }


        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();

        frmpre_compraXpresupuesto frm;
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        cp_proveedor_Bus proveedorB = new cp_proveedor_Bus();
        pre_ordencompra_local_Bus oc_B = new pre_ordencompra_local_Bus();
        pre_ordencompra_local_Info oc_I = new pre_ordencompra_local_Info();

       void  loadData()
        {
            try 
	        {
                gridControl_OC.DataSource = oc_B.ObtenerList(param.IdEmpresa, param.IdSucursal);
	        }
	        catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
	        }
        }

        private void llamaFrmMant(Cl_Enumeradores.eTipo_action Accion, pre_ordencompra_local_Info Info)
        {
            try
            {
                frm = new frmpre_compraXpresupuesto();
                frm.event_frmpre_compraXpresupuesto_FormClosing += new frmpre_compraXpresupuesto.delegate_frmpre_compraXpresupuesto_FormClosing(frm_event_frmpre_compraXpresupuesto_FormClosing);      //.event_frmpre_pedidoProducto_FormClosing += new frmpre_pedidoProducto.delegate_frmpre_pedidoProducto_FormClosing(frm_event_frmpre_pedidoProducto_FormClosing);
                frm.MdiParent = this.MdiParent;
                frm.set_accion(Accion);

               frm.Show();
                if (!(Accion == Cl_Enumeradores.eTipo_action.grabar))
                {
                  frm.set_PedidoOC(Info);
                }
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

        void frm_event_frmpre_compraXpresupuesto_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
              loadData();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }

        }

        private void frmpre_compraXpresupuesto_Consulta_Load(object sender, EventArgs e){}

        private void UltraGrid_OC_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                oc_I = (pre_ordencompra_local_Info)UltraGrid_OC.GetFocusedRow();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
           
        }

        private void UltraGrid_OC_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                var data = UltraGrid_OC.GetRow(e.RowHandle) as pre_ordencompra_local_Info;
                if (data == null)
                    return;
                if (data.Estado == "I")
                    e.Appearance.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
            }
        }

    }
}
