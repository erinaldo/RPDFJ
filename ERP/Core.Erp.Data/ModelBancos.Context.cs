﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntitiesBanco : DbContext
    {
        public EntitiesBanco()
            : base("name=EntitiesBanco")
        {
        }
        public void SetCommandTimeOut(int TimeOut)
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = TimeOut;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ba_Archivo_Transferencia_Parametros> ba_Archivo_Transferencia_Parametros { get; set; }
        public DbSet<ba_Banco_Cuenta> ba_Banco_Cuenta { get; set; }
        public DbSet<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito> ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito { get; set; }
        public DbSet<ba_Catalogo> ba_Catalogo { get; set; }
        public DbSet<ba_CatalogoTipo> ba_CatalogoTipo { get; set; }
        public DbSet<ba_Cbte_Ban_tipo> ba_Cbte_Ban_tipo { get; set; }
        public DbSet<ba_Cbte_Ban_tipo_x_CodBancoExterno> ba_Cbte_Ban_tipo_x_CodBancoExterno { get; set; }
        public DbSet<ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo> ba_Cbte_Ban_tipo_x_ct_CbteCble_tipo { get; set; }
        public DbSet<ba_cbte_ban_verificado> ba_cbte_ban_verificado { get; set; }
        public DbSet<ba_Conciliacion_det_IngEgr> ba_Conciliacion_det_IngEgr { get; set; }
        public DbSet<ba_Config_Diseno_Cheque> ba_Config_Diseno_Cheque { get; set; }
        public DbSet<ba_Inversion> ba_Inversion { get; set; }
        public DbSet<ba_notasDebCre_masivo> ba_notasDebCre_masivo { get; set; }
        public DbSet<ba_prestamo_detalle> ba_prestamo_detalle { get; set; }
        public DbSet<ba_prestamo_detalle_cancelacion> ba_prestamo_detalle_cancelacion { get; set; }
        public DbSet<ba_prestamo_detalle_x_af_activo_fijo_Prendados> ba_prestamo_detalle_x_af_activo_fijo_Prendados { get; set; }
        public DbSet<ba_Talonario_cheques_x_banco> ba_Talonario_cheques_x_banco { get; set; }
        public DbSet<ba_tipo_nota> ba_tipo_nota { get; set; }
        public DbSet<ba_transferencia> ba_transferencia { get; set; }
        public DbSet<vwba_ba_Banco_Cuenta> vwba_ba_Banco_Cuenta { get; set; }
        public DbSet<vwba_Banco_Estado_Cheques> vwba_Banco_Estado_Cheques { get; set; }
        public DbSet<vwba_Banco_Movimiento_det_cancelado> vwba_Banco_Movimiento_det_cancelado { get; set; }
        public DbSet<vwba_Catalogo_IdAuto_numeric> vwba_Catalogo_IdAuto_numeric { get; set; }
        public DbSet<vwba_Cbte_Ban_detallePagos> vwba_Cbte_Ban_detallePagos { get; set; }
        public DbSet<vwba_Conciliacion_det_IngEgr> vwba_Conciliacion_det_IngEgr { get; set; }
        public DbSet<vwba_Estado_cbte_ban> vwba_Estado_cbte_ban { get; set; }
        public DbSet<vwba_EstadoPago> vwba_EstadoPago { get; set; }
        public DbSet<vwba_MetodoCalculo> vwba_MetodoCalculo { get; set; }
        public DbSet<vwba_MotivoPrestamo> vwba_MotivoPrestamo { get; set; }
        public DbSet<vwba_notasDebCre_masivo> vwba_notasDebCre_masivo { get; set; }
        public DbSet<vwba_notasDebCre_masivo_consul> vwba_notasDebCre_masivo_consul { get; set; }
        public DbSet<vwba_ordenGiroPendientes> vwba_ordenGiroPendientes { get; set; }
        public DbSet<vwba_PeriocidadPago> vwba_PeriocidadPago { get; set; }
        public DbSet<vwba_prestamo> vwba_prestamo { get; set; }
        public DbSet<vwba_prestamo_detalle_cancelacion> vwba_prestamo_detalle_cancelacion { get; set; }
        public DbSet<vwBA_Sucursal_x_TipoCobro> vwBA_Sucursal_x_TipoCobro { get; set; }
        public DbSet<vwba_tipo_nota> vwba_tipo_nota { get; set; }
        public DbSet<vwba_transferencia> vwba_transferencia { get; set; }
        public DbSet<vwba_ba_prestamo_detalle_x_af_activo_fijo_Prendados> vwba_ba_prestamo_detalle_x_af_activo_fijo_Prendados { get; set; }
        public DbSet<vwba_MoviCaja_Depositados> vwba_MoviCaja_Depositados { get; set; }
        public DbSet<ba_Conciliacion> ba_Conciliacion { get; set; }
        public DbSet<vwba_Conciliacion> vwba_Conciliacion { get; set; }
        public DbSet<ba_TipoFlujo> ba_TipoFlujo { get; set; }
        public DbSet<vwba_TipoFlujo> vwba_TipoFlujo { get; set; }
        public DbSet<ba_Cbte_Ban> ba_Cbte_Ban { get; set; }
        public DbSet<ba_Archivo_Transferencia_x_PreAviso_Cheq> ba_Archivo_Transferencia_x_PreAviso_Cheq { get; set; }
        public DbSet<ba_Archivo_Transferencia_x_PreAviso_Cheq_det> ba_Archivo_Transferencia_x_PreAviso_Cheq_det { get; set; }
        public DbSet<vwba_Archivo_Transferencia_Det_sum_valores> vwba_Archivo_Transferencia_Det_sum_valores { get; set; }
        public DbSet<vwba_Archivo_Transferencia_x_PreAviso_Cheq> vwba_Archivo_Transferencia_x_PreAviso_Cheq { get; set; }
        public DbSet<vwba_Archivo_Transferencia_x_PreAviso_Cheq_det> vwba_Archivo_Transferencia_x_PreAviso_Cheq_det { get; set; }
        public DbSet<vwba_op_ba_Archivo_Transferencia_Det> vwba_op_ba_Archivo_Transferencia_Det { get; set; }
        public DbSet<vwba_Cbte_Ban_tipo_x_ct_CbteCble_tipo> vwba_Cbte_Ban_tipo_x_ct_CbteCble_tipo { get; set; }
        public DbSet<ba_Cbte_Ban_Datos_Entrega_cheq> ba_Cbte_Ban_Datos_Entrega_cheq { get; set; }
        public DbSet<vwba_Cbte_Ban> vwba_Cbte_Ban { get; set; }
        public DbSet<ba_Archivo_Transferencia> ba_Archivo_Transferencia { get; set; }
        public DbSet<vwba_TransaccionesAConciliar> vwba_TransaccionesAConciliar { get; set; }
        public DbSet<ba_prestamo> ba_prestamo { get; set; }
        public DbSet<vwBa_ChequexCbteCtble> vwBa_ChequexCbteCtble { get; set; }
        public DbSet<ba_parametros> ba_parametros { get; set; }
        public DbSet<vwba_Archivo_Transferencia> vwba_Archivo_Transferencia { get; set; }
        public DbSet<vwba_Archivo_Transferencia_Det_mov_caj_x_cobro> vwba_Archivo_Transferencia_Det_mov_caj_x_cobro { get; set; }
        public DbSet<ba_Archivo_Transferencia_Det> ba_Archivo_Transferencia_Det { get; set; }
        public DbSet<vwba_Archivo_Transferencia_Det> vwba_Archivo_Transferencia_Det { get; set; }
    }
}