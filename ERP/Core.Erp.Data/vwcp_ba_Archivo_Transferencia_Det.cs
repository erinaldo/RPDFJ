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
    
    public partial class vwcp_ba_Archivo_Transferencia_Det
    {
        public double Valor_a_pagar { get; set; }
        public string Observacion { get; set; }
        public string CodPersona { get; set; }
        public string pe_Naturaleza { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_apellido { get; set; }
        public string pe_razonSocial { get; set; }
        public string pe_nombre { get; set; }
        public int IdTipoPersona { get; set; }
        public string IdTipoDocumento { get; set; }
        public string pe_cedulaRuc { get; set; }
        public decimal IdPersona { get; set; }
        public System.DateTime Fecha_Pago { get; set; }
        public bool Estado { get; set; }
        public string IdEstadoRegistro_cat { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdArchivo { get; set; }
        public string IdProceso_bancario { get; set; }
        public int Secuencia { get; set; }
        public Nullable<int> IdEmpresa_OP { get; set; }
        public Nullable<decimal> IdOrdenPago { get; set; }
        public Nullable<int> Secuencia_OP { get; set; }
        public string IdTipo_Persona { get; set; }
        public Nullable<decimal> IdEntidad { get; set; }
    }
}