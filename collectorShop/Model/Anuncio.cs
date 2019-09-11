using System.ComponentModel.DataAnnotations;

namespace Model
{
    public partial class Anuncio
    {
        [Required]
        [Display(Name = "Código Anúncio")]
        public int CodAnuncio { get; set; }
        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }
        [Required]
        [Display(Name = "Quantidade anunciada")]
        public int QuantAnunciada { get; set; }
        [Required]
        [Display(Name = "Quantidade disponível")]
        public int? QuantDisponivel { get; set; }
        [Required]
        [Display(Name ="Título")]
        [StringLength(45)]
        public string Titulo { get; set; }
        [Required]
        [Display(Name = "Descrição")]
        [StringLength(100)]
        public string Descricao { get; set; }
        [Required]
        [Display(Name = "Valor")]
        public float? Valor { get; set; }
        [Required]
        [Display(Name = "Código do Usuário")]
        public int CodUsuario { get; set; }
        
        [Display(Name = "Opções de Envio")]
        public string OpcaoEnvio { get; set; }

        [Display(Name = "Categoria")]
        public string NomeCategoria { get; set; }
        [Display(Name = "Vendedor")]
        public string NomeUsuario { get; set; }

        [Display(Name = "Subcategoria")]
        public string NomeSubcategoria { get; set; }

        public int CodSubcategoria { get; set; }

        public int CodCategoria { get; set; }

    }
}
