// arquivo: Livro.cs
using System.ComponentModel.DataAnnotations;

namespace API.biblioteca.Models
{
    public class Livro
    {
        public Guid LivroId { get; set; }
        [Required]
        public string? Titulo { get; set; }
        [Required]
        public string? Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public string? ISBN10 { get; set; }
        public string? ISBN13 { get; set; }
        [Required]
        public string? UrlCapa { get; set; }
        [Required]
        public string? Editora { get; set; }
        [Required]
        public string? Edicao { get; set; }

        // Propriedade de navegação para a relação muitos-para-muitos com Genero
        public ICollection<Livro>? LivrosGeneros { get; set; }

    }
}