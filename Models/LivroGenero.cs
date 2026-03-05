// arquivo: LivroGenero.cs


namespace API.biblioteca.Models
{
    public class LivroGenero
    {
        public Guid LivroGeneroId { get; set; }

        // Chave estrangeira para Livro
        public Guid LivroId { get; set; }
        // Propriedade de navegação para Livro
        public Livro? Livro { get; set; }

        // Chave estrangeira para Genero
        public Guid GeneroId { get; set; }
        // Propriedade de navegação para Genero
        public Genero? Genero { get; set; }
    }
}