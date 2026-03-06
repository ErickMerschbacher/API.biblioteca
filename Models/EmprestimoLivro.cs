namespace API.biblioteca.Models
{
    public class EmprestimoLivro
    {
        public Guid EmprestimoLivroId { get; set; }

        // Chave estrangeira para Emprestimo
        public Guid EmprestimoId { get; set; }
        // Propriedade de navegação para Emprestimo
        public Emprestimo? Emprestimo { get; set; }

        // Chave estrangeira para Livro
        public Guid LivroId { get; set; }
        // Propriedade de navegação para Livro
        public Livro? Livro { get; set; }
    }
}
