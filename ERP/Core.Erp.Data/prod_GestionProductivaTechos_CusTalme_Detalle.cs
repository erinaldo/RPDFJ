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
    
    public partial class prod_GestionProductivaTechos_CusTalme_Detalle
    {
        public int IdEmpresa { get; set; }
        public decimal IdGestionProductiva { get; set; }
        public int Secuencia { get; set; }
        public Nullable<decimal> Prod_IdProducto { get; set; }
        public Nullable<double> Prod_Largo { get; set; }
        public Nullable<double> Prod_Ancho { get; set; }
        public Nullable<double> Prod_PsoEsp { get; set; }
        public Nullable<double> Prod_Espesor { get; set; }
        public Nullable<double> Prod_PsoUnd { get; set; }
        public Nullable<double> Prducc_Unidades { get; set; }
        public Nullable<double> Prducc_Kg { get; set; }
        public Nullable<decimal> Segunda_IdProducto { get; set; }
        public Nullable<double> Segunda_Unidades { get; set; }
        public Nullable<double> Segunda_Kg { get; set; }
        public Nullable<double> Chatarra_Kg { get; set; }
        public Nullable<double> Peso { get; set; }
        public Nullable<double> Kg_Desp { get; set; }
        public Nullable<double> Rend_Metalico { get; set; }
        public Nullable<double> KW { get; set; }
        public Nullable<System.TimeSpan> Tiempo_Preparacion { get; set; }
        public Nullable<System.TimeSpan> Tiempo_Produccion { get; set; }
        public Nullable<System.TimeSpan> Tiempo_Total { get; set; }
        public Nullable<System.TimeSpan> Parada_Mecanica { get; set; }
        public Nullable<System.TimeSpan> Parada_Electrico { get; set; }
        public Nullable<System.TimeSpan> Parada_Logistica { get; set; }
        public Nullable<System.TimeSpan> Parada_Otros { get; set; }
        public Nullable<System.TimeSpan> TotalParos { get; set; }
        public Nullable<double> Indicadores_TnHrs { get; set; }
        public Nullable<double> Indicadores_TimeParda { get; set; }
        public Nullable<double> Indicadores_UndsHrs { get; set; }
        public Nullable<double> Indicadores_Calidad { get; set; }
    }
}
