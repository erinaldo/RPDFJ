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
    
    public partial class ro_empleado_x_ro_tipoNomina
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdTipoNomina { get; set; }
        public string observacion { get; set; }
    
        public virtual ro_Nomina_Tipo ro_Nomina_Tipo { get; set; }
        public virtual ro_empleado ro_empleado { get; set; }
    }
}
