using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Model
{
    public class Negociacao
    {
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Key]
        public int CodNegociacao { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public DateTime Data { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [Display(Name = "Valor proposto para troca")]
        public float ValorProposto { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [Display(Name = "Status")]
        public string Status { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [Display(Name = "Modalidade de negociação:")]
        public string Tipo { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public int CodUsuario { get; set; }
      //  [System.ComponentModel.DataAnnotations.Required]
        public string nomeUsuario { get; set; }
        public int AnuncioUsuario { get; set; }
    }
}
