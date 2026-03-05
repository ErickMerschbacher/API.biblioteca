
using System.ComponentModel.DataAnnotations;

namespace API.biblioteca.Models
{
    public class Genero
    {
        public Guid GeneroId { get; set; }
        [Required] // O nome do gênero é obrigatório
        public string? Nome { get; set; }
        // Propriedade de navegação para a relação muitos-para-muitos com Livro
        public ICollection<Livro>? Livros { get; set; }
    }
}
