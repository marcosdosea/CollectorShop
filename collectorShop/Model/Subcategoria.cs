using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public partial class Subcategoria
    {
        [Required]
        [Key]
        [Display(Name = "Código da Subcategoria")]
        public int CodSubcategoria { get; set; }
        [Required]
        [StringLength(45, MinimumLength = 5)]
        [Display(Name = "Nome da subcategoria")]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Código da categoria")]
        public int CodCategoria { get; set; }

        public String NomeCategoria { get; set; }

    }
}
