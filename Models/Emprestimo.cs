
// arquivo: Emprestimo.cs

namespace API.biblioteca.Models
{
    public class Emprestimo
    {
        public Guid EmprestimoId { get; set; }

        // Campo Data e Hora do empréstimo, com valor padrão definido para a data e hora atual
        public DateTime? DataEmprestimo { get; set; } = DateTime.Now;

        public DateTime? DataDevolucao { get; set; } = DateTime.Now.AddDays(10); // Definindo a data de devolução para 7 dias após o empréstimo

        public bool Devolvido { get; set; } = false; // Campo para indicar se o livro foi devolvido, com valor padrão definido para false

        // Chave estrangeira para Cliente
        public Guid ClienteId { get; set; }
        // Propriedade de navegação para Cliente
        public Cliente? Cliente { get; set; }

    }
}
