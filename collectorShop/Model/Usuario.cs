using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public partial class Usuario
    {
        [Required]
        [Display(Name = "Código do usuário")]
        public int CodUsuario { get; set; }
        [Required]
        [StringLength(11)]
        [Display(Name = "Cpf")]
        public string Cpf { get; set; }
        [Required]
        [StringLength(45, MinimumLength = 5)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }
        [Required]
        [StringLength(45, MinimumLength = 5)]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }
        [Required]
        [StringLength(45, MinimumLength = 5)]
        [Display(Name = "Estado")]
        public string Estado { get; set; }
        [Required]
        [StringLength(45, MinimumLength = 5)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [StringLength(45, MinimumLength = 5)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Required]
        [StringLength(45, MinimumLength = 8)]
        [Display(Name = "Cep")]
        public string Cep { get; set; }
        [Required]
        [Display(Name = "Flag Administrador")]
        public String Administrador { get; set; }

    }
}
