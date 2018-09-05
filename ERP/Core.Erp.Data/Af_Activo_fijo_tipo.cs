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
    
    public partial class Af_Activo_fijo_tipo
    {
        public Af_Activo_fijo_tipo()
        {
            this.Af_Activo_fijo = new HashSet<Af_Activo_fijo>();
            this.Af_Activo_fijo_Categoria = new HashSet<Af_Activo_fijo_Categoria>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdActijoFijoTipo { get; set; }
        public string CodActivoFijo { get; set; }
        public string Af_Descripcion { get; set; }
        public double Af_Porcentaje_depre { get; set; }
        public int Af_anio_depreciacion { get; set; }
        public string IdCtaCble_Activo { get; set; }
        public string IdCtaCble_Dep_Acum { get; set; }
        public string IdCtaCble_Gastos_Depre { get; set; }
        public string IdCentroCosto_Activo { get; set; }
        public string IdCentroCosto_Dep_Acum { get; set; }
        public string IdCentroCosto_Gasto_Depre { get; set; }
        public Nullable<bool> Se_Deprecia { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string MotiAnula { get; set; }
    
        public virtual ICollection<Af_Activo_fijo> Af_Activo_fijo { get; set; }
        public virtual ICollection<Af_Activo_fijo_Categoria> Af_Activo_fijo_Categoria { get; set; }
    }
}