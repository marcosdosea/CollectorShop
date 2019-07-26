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
        public string Nome { get; set; }
    }
}
