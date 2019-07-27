using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Categoria
    {
        [Key]
        public int CodCategoria { get; set; }
        [Required]
        [Display(Name ="Nome")]
        [MaxLength(45)]
        public string Nome { get; set; }
    }
}
