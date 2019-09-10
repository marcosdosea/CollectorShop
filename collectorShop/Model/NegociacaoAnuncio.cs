using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Model;

namespace Model
{
    public class NegociacaoAnuncio
    {

        [Required]
        public int CodNegociacao { get; set; }
        [Required]
        public int CodAnuncio { get; set; }


    }
}
