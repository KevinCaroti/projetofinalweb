using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalWeb.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Autor { get; set; }
        public string Sinopse { get; set; }
        public decimal Preco { get; set; }
        public string ISBN { get; set; }
        public string Editora { get; set; }
        public string Idioma { get; set; }
        public string Tema { get; set; }
        public string Dimensao { get; set; }
        public bool Disponivel { get; set; }
    }
    public class Encomenda
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int LivroId { get; set; }

        [ForeignKey("LivroId")]
        public Livro Livro { get; set; } // Relacionamento com o modelo Livro

        [Required]
        public string NomeUtilizador { get; set; }

        [Required]
        public string MoradaEnvio { get; set; }

        [Required]
        public string Estado { get; set; } = "Pendente"; // Estado da encomenda: Pendente ou Satisfeita
    }
}
