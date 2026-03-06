namespace API.biblioteca.Models
{
    public class Devolucao
    {
        public Guid DevolucaoId { get; set; }
        // Campo Data e Hora da devolução, com valor padrão definido para a data e hora atual
        public DateTime? DataDevolucao { get; set; } = DateTime.Now;
        // Chave estrangeira para Emprestimo
        public Guid EmprestimoId { get; set; }
        // Propriedade de navegação para Emprestimo
        public Emprestimo? Emprestimo { get; set; }
        public bool Atrasado { get; set; } = false; // Campo para indicar se a devolução foi feita com atraso, com valor padrão definido para false
    }
}
