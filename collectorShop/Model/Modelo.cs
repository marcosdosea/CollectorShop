using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public partial class Modelo
    {


        [Key]
        public int CodModelo { get; set; }
        [Required]
        [Display(Name = "Nome")]
        [StringLength(45)]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Tiragem")]
        [StringLength(45)]
        public string QuantTiragem { get; set; }
        [Required]
        [Display(Name = "Colecao")]
        [StringLength(45)]
        public string Colecao { get; set; }
        [Required]
        [Display(Name = "Label")]
        [StringLength(45)]
        public string Label { get; set; }
        [Required]
        [Display(Name = "Marca")]
        [StringLength(45)]
        public string Marca { get; set; }
        [Required]
        [Display(Name = "Ano")]
        [StringLength(4)]
        public string Ano { get; set; }
        [Required]
        [Display(Name = "SubCategoria")]
        public int CodSubcategoria { get; set; }
        [Required]
        [Display(Name = "Codigo do Usuario")]
        public int CodUsuario { get; set; }

        public string nomeSubCategoria { get; set; }
        public string nomeUsuario { get; set; }


    }
}
