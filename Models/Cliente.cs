using System.ComponentModel.DataAnnotations;

namespace API.biblioteca.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Celular { get; set; }
        [Required]
        public DateOnly DataNascimento { get; set; }
    }
}
