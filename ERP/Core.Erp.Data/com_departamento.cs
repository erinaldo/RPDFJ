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
    
    public partial class com_departamento
    {
        public com_departamento()
        {
            this.com_ordencompra_local = new HashSet<com_ordencompra_local>();
            this.com_solicitud_compra = new HashSet<com_solicitud_compra>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdDepartamento { get; set; }
        public string nom_departamento { get; set; }
        public string Estado { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
    
        public virtual ICollection<com_ordencompra_local> com_ordencompra_local { get; set; }
        public virtual ICollection<com_solicitud_compra> com_solicitud_compra { get; set; }
    }
}
