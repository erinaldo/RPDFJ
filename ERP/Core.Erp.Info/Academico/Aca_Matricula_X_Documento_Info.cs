﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Info.Academico
{
  public  class Aca_Matricula_x_Documento_Info
    {

        public int IdInstitucion { get; set; }
        public int IdSede { get; set; }
        public decimal IdMatricula { get; set; }
        public int IdTipoDocumento { get; set; }
        public string Observacion { get; set; }        
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public DateTime? FechaAnulacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string UsuarioAnulacion { get; set; }
        public byte[] Archivo { get; set; }
        public int Existe_en_Base { get; set; }
        public string sLink { get; set; }


        public Aca_Matricula_x_Documento_Info() { }

    }
}
