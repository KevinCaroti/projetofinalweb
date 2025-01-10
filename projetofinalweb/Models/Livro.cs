﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalWeb.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Nome { get; set; }

        public required string Autor { get; set; }
        public required string Sinopse { get; set; }
        public required decimal Preco { get; set; }
        public required string ISBN { get; set; }
        public required string Editora { get; set; }
        public required string Idioma { get; set; }
        public required string Tema { get; set; }
        public required string Dimensao { get; set; }
        public bool Disponivel { get; set; }
    }
    public class Encomenda
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int LivroId { get; set; }

        [ForeignKey("LivroId")]
        public required Livro Livro { get; set; } // Relacionamento com o modelo Livro

        [Required]
        public required string NomeUtilizador { get; set; }

        [Required]
        public required string MoradaEnvio { get; set; }

        [Required]
        public string Estado { get; set; } = "Pendente"; // Estado da encomenda: Pendente ou Satisfeita
    }
}
