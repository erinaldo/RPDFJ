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
    
    public partial class ro_historico_vacaciones_x_empleado
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdHis_Vacaciones { get; set; }
        public int Secuencia { get; set; }
        public Nullable<System.DateTime> FechaIni { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public Nullable<int> DiasGanado { get; set; }
        public Nullable<int> DiasTomados { get; set; }
    }
}