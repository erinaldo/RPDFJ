﻿namespace Core.Erp.Winform.Facturacion_Fj
{
    partial class Frmfa_pre_facturacion_Parametro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chk_se_cobra_iva = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucFa_Catalogos_Cmb = new Core.Erp.Winform.Controles.UCFa_CatalogosCmb();
            this.ucGe_Menu_Superior_Mant = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Generales = new System.Windows.Forms.TabPage();
            this.chk_se_liquida_x_grupos = new System.Windows.Forms.CheckBox();
            this.Liqui_Gastos = new System.Windows.Forms.TabPage();
            this.gc_Liqui_tipo_proc = new DevExpress.XtraGrid.GridControl();
            this.gw_Liqui_tipo_proc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdTipo_Proceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_IdTipo_Proceso_x_Liqui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdProducto_Liqui_x_defecto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_Liqui_Gasto_Producto = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdProducto_Liqui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_nom_producto_Liqui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuStrip_Liqui_Gastos = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl_margen_ganancia_por_fuerza = new DevExpress.XtraGrid.GridControl();
            this.gridView_margen_ganancia_por_fuerza = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_Anio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Mes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Porcentaje_Calculo_BS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Porcentaje_Calculo_MO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_fuerza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmb_fuerza = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_fu_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.Generales.SuspendLayout();
            this.Liqui_Gastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Liqui_tipo_proc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_Liqui_tipo_proc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Liqui_Gasto_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.menuStrip_Liqui_Gastos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_margen_ganancia_por_fuerza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_margen_ganancia_por_fuerza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_fuerza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_se_cobra_iva
            // 
            this.chk_se_cobra_iva.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_se_cobra_iva.Location = new System.Drawing.Point(25, 75);
            this.chk_se_cobra_iva.Name = "chk_se_cobra_iva";
            this.chk_se_cobra_iva.Size = new System.Drawing.Size(134, 17);
            this.chk_se_cobra_iva.TabIndex = 1;
            this.chk_se_cobra_iva.Text = "Se Cobra Iva    ";
            this.chk_se_cobra_iva.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de \r\ncobro de Poliza";
            // 
            // ucFa_Catalogos_Cmb
            // 
            this.ucFa_Catalogos_Cmb.Location = new System.Drawing.Point(139, 16);
            this.ucFa_Catalogos_Cmb.Name = "ucFa_Catalogos_Cmb";
            this.ucFa_Catalogos_Cmb.Size = new System.Drawing.Size(306, 30);
            this.ucFa_Catalogos_Cmb.TabIndex = 3;
            this.ucFa_Catalogos_Cmb.Visible_cmb_Accion = false;
            // 
            // ucGe_Menu_Superior_Mant
            // 
            this.ucGe_Menu_Superior_Mant.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Superior_Mant.Enabled_bnRetImprimir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntAnular = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntAprobar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntImprimir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntLimpiar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_bntSalir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnAceptar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnEstadosOC = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpFrm = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpLote = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImpRep = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu_Superior_Mant.Enabled_btnproductos = true;
            this.ucGe_Menu_Superior_Mant.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Superior_Mant.Name = "ucGe_Menu_Superior_Mant";
            this.ucGe_Menu_Superior_Mant.Size = new System.Drawing.Size(745, 29);
            this.ucGe_Menu_Superior_Mant.TabIndex = 0;
            this.ucGe_Menu_Superior_Mant.Visible_bntAnular = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntAprobar = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntGuardar_y_Salir = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntImprimir = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntLimpiar = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntReImprimir = false;
            this.ucGe_Menu_Superior_Mant.Visible_bntSalir = true;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Actualizar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Generar_XML = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu_Superior_Mant.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnAceptar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnContabilizar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnEstadosOC = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnGuardar = true;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpFrm = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpLote = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImpRep = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnModificar = false;
            this.ucGe_Menu_Superior_Mant.Visible_btnproductos = false;
            this.ucGe_Menu_Superior_Mant.event_btnGuardar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnGuardar_Click(this.ucGe_Menu_Superior_Mant_event_btnGuardar_Click);
            this.ucGe_Menu_Superior_Mant.event_btnSalir_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant.delegate_btnSalir_Click(this.ucGe_Menu_Superior_Mant_event_btnSalir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Generales);
            this.tabControl1.Controls.Add(this.Liqui_Gastos);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(739, 397);
            this.tabControl1.TabIndex = 4;
            // 
            // Generales
            // 
            this.Generales.Controls.Add(this.chk_se_liquida_x_grupos);
            this.Generales.Controls.Add(this.label1);
            this.Generales.Controls.Add(this.ucFa_Catalogos_Cmb);
            this.Generales.Controls.Add(this.chk_se_cobra_iva);
            this.Generales.Location = new System.Drawing.Point(4, 22);
            this.Generales.Name = "Generales";
            this.Generales.Padding = new System.Windows.Forms.Padding(3);
            this.Generales.Size = new System.Drawing.Size(731, 371);
            this.Generales.TabIndex = 0;
            this.Generales.Text = "Generales";
            this.Generales.UseVisualStyleBackColor = true;
            // 
            // chk_se_liquida_x_grupos
            // 
            this.chk_se_liquida_x_grupos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_se_liquida_x_grupos.Location = new System.Drawing.Point(25, 52);
            this.chk_se_liquida_x_grupos.Name = "chk_se_liquida_x_grupos";
            this.chk_se_liquida_x_grupos.Size = new System.Drawing.Size(134, 17);
            this.chk_se_liquida_x_grupos.TabIndex = 4;
            this.chk_se_liquida_x_grupos.Text = "Se liquida por grupos";
            this.chk_se_liquida_x_grupos.UseVisualStyleBackColor = true;
            // 
            // Liqui_Gastos
            // 
            this.Liqui_Gastos.Controls.Add(this.gc_Liqui_tipo_proc);
            this.Liqui_Gastos.Controls.Add(this.menuStrip_Liqui_Gastos);
            this.Liqui_Gastos.Location = new System.Drawing.Point(4, 22);
            this.Liqui_Gastos.Name = "Liqui_Gastos";
            this.Liqui_Gastos.Padding = new System.Windows.Forms.Padding(3);
            this.Liqui_Gastos.Size = new System.Drawing.Size(731, 371);
            this.Liqui_Gastos.TabIndex = 1;
            this.Liqui_Gastos.Text = "Liquidacion de Gastos";
            this.Liqui_Gastos.UseVisualStyleBackColor = true;
            // 
            // gc_Liqui_tipo_proc
            // 
            this.gc_Liqui_tipo_proc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Liqui_tipo_proc.Location = new System.Drawing.Point(3, 27);
            this.gc_Liqui_tipo_proc.MainView = this.gw_Liqui_tipo_proc;
            this.gc_Liqui_tipo_proc.Name = "gc_Liqui_tipo_proc";
            this.gc_Liqui_tipo_proc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_Liqui_Gasto_Producto});
            this.gc_Liqui_tipo_proc.Size = new System.Drawing.Size(725, 341);
            this.gc_Liqui_tipo_proc.TabIndex = 1;
            this.gc_Liqui_tipo_proc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gw_Liqui_tipo_proc});
            // 
            // gw_Liqui_tipo_proc
            // 
            this.gw_Liqui_tipo_proc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdTipo_Proceso,
            this.col_nom_IdTipo_Proceso_x_Liqui,
            this.col_IdProducto_Liqui_x_defecto});
            this.gw_Liqui_tipo_proc.GridControl = this.gc_Liqui_tipo_proc;
            this.gw_Liqui_tipo_proc.Name = "gw_Liqui_tipo_proc";
            this.gw_Liqui_tipo_proc.OptionsBehavior.ReadOnly = true;
            this.gw_Liqui_tipo_proc.OptionsView.ShowAutoFilterRow = true;
            this.gw_Liqui_tipo_proc.OptionsView.ShowGroupPanel = false;
            this.gw_Liqui_tipo_proc.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gw_Liqui_tipo_proc_FocusedRowChanged);
            // 
            // col_IdTipo_Proceso
            // 
            this.col_IdTipo_Proceso.Caption = "IdTipo_Proceso";
            this.col_IdTipo_Proceso.FieldName = "IdTipo_Proceso";
            this.col_IdTipo_Proceso.Name = "col_IdTipo_Proceso";
            this.col_IdTipo_Proceso.Visible = true;
            this.col_IdTipo_Proceso.VisibleIndex = 0;
            this.col_IdTipo_Proceso.Width = 278;
            // 
            // col_nom_IdTipo_Proceso_x_Liqui
            // 
            this.col_nom_IdTipo_Proceso_x_Liqui.Caption = "nom_IdTipo_Proceso_x_Liqui";
            this.col_nom_IdTipo_Proceso_x_Liqui.FieldName = "nom_IdTipo_Proceso_x_Liqui";
            this.col_nom_IdTipo_Proceso_x_Liqui.Name = "col_nom_IdTipo_Proceso_x_Liqui";
            this.col_nom_IdTipo_Proceso_x_Liqui.Visible = true;
            this.col_nom_IdTipo_Proceso_x_Liqui.VisibleIndex = 1;
            this.col_nom_IdTipo_Proceso_x_Liqui.Width = 436;
            // 
            // col_IdProducto_Liqui_x_defecto
            // 
            this.col_IdProducto_Liqui_x_defecto.Caption = "IdProducto_Liqui_x_defecto";
            this.col_IdProducto_Liqui_x_defecto.ColumnEdit = this.cmb_Liqui_Gasto_Producto;
            this.col_IdProducto_Liqui_x_defecto.FieldName = "IdProducto_Liqui_x_defecto";
            this.col_IdProducto_Liqui_x_defecto.Name = "col_IdProducto_Liqui_x_defecto";
            this.col_IdProducto_Liqui_x_defecto.Visible = true;
            this.col_IdProducto_Liqui_x_defecto.VisibleIndex = 2;
            this.col_IdProducto_Liqui_x_defecto.Width = 427;
            // 
            // cmb_Liqui_Gasto_Producto
            // 
            this.cmb_Liqui_Gasto_Producto.AutoHeight = false;
            this.cmb_Liqui_Gasto_Producto.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Liqui_Gasto_Producto.DisplayMember = "nom_producto_Liqui";
            this.cmb_Liqui_Gasto_Producto.Name = "cmb_Liqui_Gasto_Producto";
            this.cmb_Liqui_Gasto_Producto.ValueMember = "IdProducto_Liqui";
            this.cmb_Liqui_Gasto_Producto.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdProducto_Liqui,
            this.col_nom_producto_Liqui});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // col_IdProducto_Liqui
            // 
            this.col_IdProducto_Liqui.Caption = "IdProducto_Liqui";
            this.col_IdProducto_Liqui.FieldName = "IdProducto_Liqui";
            this.col_IdProducto_Liqui.Name = "col_IdProducto_Liqui";
            this.col_IdProducto_Liqui.Visible = true;
            this.col_IdProducto_Liqui.VisibleIndex = 1;
            this.col_IdProducto_Liqui.Width = 119;
            // 
            // col_nom_producto_Liqui
            // 
            this.col_nom_producto_Liqui.Caption = "nom_producto_Liqui";
            this.col_nom_producto_Liqui.FieldName = "nom_producto_Liqui";
            this.col_nom_producto_Liqui.Name = "col_nom_producto_Liqui";
            this.col_nom_producto_Liqui.Visible = true;
            this.col_nom_producto_Liqui.VisibleIndex = 0;
            this.col_nom_producto_Liqui.Width = 1022;
            // 
            // menuStrip_Liqui_Gastos
            // 
            this.menuStrip_Liqui_Gastos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.menuStrip_Liqui_Gastos.Location = new System.Drawing.Point(3, 3);
            this.menuStrip_Liqui_Gastos.Name = "menuStrip_Liqui_Gastos";
            this.menuStrip_Liqui_Gastos.Size = new System.Drawing.Size(725, 24);
            this.menuStrip_Liqui_Gastos.TabIndex = 0;
            this.menuStrip_Liqui_Gastos.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 371);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Parametros por Mano de Obra (RRHH)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl_margen_ganancia_por_fuerza);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(725, 365);
            this.groupControl2.TabIndex = 14;
            this.groupControl2.Text = "Margen de ganancia por fuerza por periodo";
            // 
            // gridControl_margen_ganancia_por_fuerza
            // 
            this.gridControl_margen_ganancia_por_fuerza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_margen_ganancia_por_fuerza.Location = new System.Drawing.Point(2, 21);
            this.gridControl_margen_ganancia_por_fuerza.MainView = this.gridView_margen_ganancia_por_fuerza;
            this.gridControl_margen_ganancia_por_fuerza.Name = "gridControl_margen_ganancia_por_fuerza";
            this.gridControl_margen_ganancia_por_fuerza.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmb_fuerza});
            this.gridControl_margen_ganancia_por_fuerza.Size = new System.Drawing.Size(721, 342);
            this.gridControl_margen_ganancia_por_fuerza.TabIndex = 13;
            this.gridControl_margen_ganancia_por_fuerza.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_margen_ganancia_por_fuerza});
            // 
            // gridView_margen_ganancia_por_fuerza
            // 
            this.gridView_margen_ganancia_por_fuerza.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_Anio,
            this.col_Mes,
            this.Col_Porcentaje_Calculo_BS,
            this.Col_Porcentaje_Calculo_MO,
            this.Col_fuerza});
            this.gridView_margen_ganancia_por_fuerza.GridControl = this.gridControl_margen_ganancia_por_fuerza;
            this.gridView_margen_ganancia_por_fuerza.Name = "gridView_margen_ganancia_por_fuerza";
            this.gridView_margen_ganancia_por_fuerza.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView_margen_ganancia_por_fuerza.OptionsView.ShowGroupPanel = false;
            // 
            // Col_Anio
            // 
            this.Col_Anio.Caption = "Año";
            this.Col_Anio.FieldName = "Anio";
            this.Col_Anio.Name = "Col_Anio";
            this.Col_Anio.Visible = true;
            this.Col_Anio.VisibleIndex = 1;
            this.Col_Anio.Width = 87;
            // 
            // col_Mes
            // 
            this.col_Mes.Caption = "Mes";
            this.col_Mes.FieldName = "Mes";
            this.col_Mes.Name = "col_Mes";
            this.col_Mes.Visible = true;
            this.col_Mes.VisibleIndex = 2;
            this.col_Mes.Width = 67;
            // 
            // Col_Porcentaje_Calculo_BS
            // 
            this.Col_Porcentaje_Calculo_BS.Caption = "Margen Ganacia B.S";
            this.Col_Porcentaje_Calculo_BS.FieldName = "Porcentaje_Calculo_BS";
            this.Col_Porcentaje_Calculo_BS.Name = "Col_Porcentaje_Calculo_BS";
            this.Col_Porcentaje_Calculo_BS.Visible = true;
            this.Col_Porcentaje_Calculo_BS.VisibleIndex = 4;
            this.Col_Porcentaje_Calculo_BS.Width = 440;
            // 
            // Col_Porcentaje_Calculo_MO
            // 
            this.Col_Porcentaje_Calculo_MO.Caption = "Margen ganancia M.O";
            this.Col_Porcentaje_Calculo_MO.FieldName = "Porcentaje_Calculo_MO";
            this.Col_Porcentaje_Calculo_MO.Name = "Col_Porcentaje_Calculo_MO";
            this.Col_Porcentaje_Calculo_MO.Visible = true;
            this.Col_Porcentaje_Calculo_MO.VisibleIndex = 3;
            this.Col_Porcentaje_Calculo_MO.Width = 430;
            // 
            // Col_fuerza
            // 
            this.Col_fuerza.Caption = "Fuerza";
            this.Col_fuerza.ColumnEdit = this.cmb_fuerza;
            this.Col_fuerza.FieldName = "IdFuerza";
            this.Col_fuerza.Name = "Col_fuerza";
            this.Col_fuerza.Visible = true;
            this.Col_fuerza.VisibleIndex = 0;
            this.Col_fuerza.Width = 156;
            // 
            // cmb_fuerza
            // 
            this.cmb_fuerza.AutoHeight = false;
            this.cmb_fuerza.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_fuerza.Name = "cmb_fuerza";
            this.cmb_fuerza.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_fu_descripcion});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Col_fu_descripcion
            // 
            this.Col_fu_descripcion.Caption = "Fuerza";
            this.Col_fu_descripcion.FieldName = "fu_descripcion";
            this.Col_fu_descripcion.Name = "Col_fu_descripcion";
            this.Col_fu_descripcion.Visible = true;
            this.Col_fu_descripcion.VisibleIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 416);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros";
            // 
            // Frmfa_pre_facturacion_Parametro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucGe_Menu_Superior_Mant);
            this.MainMenuStrip = this.menuStrip_Liqui_Gastos;
            this.Name = "Frmfa_pre_facturacion_Parametro";
            this.Text = "Frmfa_pre_facturacion_Parametro";
            this.Load += new System.EventHandler(this.Frmfa_pre_facturacion_Parametro_Load);
            this.tabControl1.ResumeLayout(false);
            this.Generales.ResumeLayout(false);
            this.Generales.PerformLayout();
            this.Liqui_Gastos.ResumeLayout(false);
            this.Liqui_Gastos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Liqui_tipo_proc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw_Liqui_tipo_proc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Liqui_Gasto_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.menuStrip_Liqui_Gastos.ResumeLayout(false);
            this.menuStrip_Liqui_Gastos.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_margen_ganancia_por_fuerza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_margen_ganancia_por_fuerza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_fuerza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu_Superior_Mant;
        private System.Windows.Forms.CheckBox chk_se_cobra_iva;
        private System.Windows.Forms.Label label1;
        private Controles.UCFa_CatalogosCmb ucFa_Catalogos_Cmb;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Generales;
        private System.Windows.Forms.TabPage Liqui_Gastos;
        private DevExpress.XtraGrid.GridControl gc_Liqui_tipo_proc;
        private DevExpress.XtraGrid.Views.Grid.GridView gw_Liqui_tipo_proc;
        private System.Windows.Forms.MenuStrip menuStrip_Liqui_Gastos;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdTipo_Proceso;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_IdTipo_Proceso_x_Liqui;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdProducto_Liqui_x_defecto;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_Liqui_Gasto_Producto;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdProducto_Liqui;
        private DevExpress.XtraGrid.Columns.GridColumn col_nom_producto_Liqui;
        private System.Windows.Forms.CheckBox chk_se_liquida_x_grupos;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl_margen_ganancia_por_fuerza;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_margen_ganancia_por_fuerza;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Anio;
        private DevExpress.XtraGrid.Columns.GridColumn col_Mes;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Porcentaje_Calculo_BS;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Porcentaje_Calculo_MO;
        private DevExpress.XtraGrid.Columns.GridColumn Col_fuerza;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmb_fuerza;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_fu_descripcion;
    }
}