using System;
using System.Collections.Generic;

namespace Model
{
    public partial class Anuncio
    {
       
        public int CodAnuncio { get; set; }
        public string Status { get; set; }
        public int QuantAnunciada { get; set; }
        public int? QuantDisponivel { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public float? Valor { get; set; }
        public int CodUsuario { get; set; }
        public string Msg { get; set; }

     
    }
}
