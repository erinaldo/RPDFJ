//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwin_devolucion_inven
    {
        public int IdEmpresa { get; set; }
        public decimal IdDev_Inven { get; set; }
        public string cod_Dev_Inven { get; set; }
        public System.DateTime Fecha { get; set; }
        public bool Devuelve_toda_tran { get; set; }
        public string estado { get; set; }
        public int IdSucursal_movi_inven { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltModi { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdusuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string observacion { get; set; }
        public string MotivoAnulacion { get; set; }
        public string nom_sucursal { get; set; }
    }
}