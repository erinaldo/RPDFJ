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
    
    public partial class cp_proveedor_codigo_SRI
    {
        public int IdEmpresa { get; set; }
        public decimal IdProveedor { get; set; }
        public int IdCodigo_SRI { get; set; }
        public string observacion { get; set; }
    
        public virtual cp_codigo_SRI cp_codigo_SRI { get; set; }
        public virtual cp_proveedor cp_proveedor { get; set; }
    }
}
