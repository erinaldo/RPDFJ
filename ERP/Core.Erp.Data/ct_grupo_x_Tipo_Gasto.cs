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
    
    public partial class ct_grupo_x_Tipo_Gasto
    {
        public ct_grupo_x_Tipo_Gasto()
        {
            this.ct_grupo_x_Tipo_Gasto1 = new HashSet<ct_grupo_x_Tipo_Gasto>();
            this.ct_plancta = new HashSet<ct_plancta>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdTipo_Gasto { get; set; }
        public Nullable<int> IdTipo_Gasto_Padre { get; set; }
        public string nom_tipo_Gasto { get; set; }
        public bool estado { get; set; }
        public Nullable<int> nivel { get; set; }
        public Nullable<int> orden { get; set; }
    
        public virtual ICollection<ct_grupo_x_Tipo_Gasto> ct_grupo_x_Tipo_Gasto1 { get; set; }
        public virtual ct_grupo_x_Tipo_Gasto ct_grupo_x_Tipo_Gasto2 { get; set; }
        public virtual ICollection<ct_plancta> ct_plancta { get; set; }
    }
}