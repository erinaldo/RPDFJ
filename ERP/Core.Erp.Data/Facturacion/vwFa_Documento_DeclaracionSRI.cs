//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Facturacion
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwFa_Documento_DeclaracionSRI
    {
        public int IdEmpresa { get; set; }
        public string IdTipoDocumento { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string vt_tipoDoc { get; set; }
        public Nullable<double> baseNoGraIva { get; set; }
        public Nullable<double> baseImpGrav { get; set; }
        public double baseImponible { get; set; }
        public double montoIva { get; set; }
        public decimal IdCbteVta { get; set; }
        public decimal IdCliente { get; set; }
        public string vt_serie1 { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public double ValorRetFT { get; set; }
        public double ValorRetIVA { get; set; }
    }
}
