using API.biblioteca.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Biblioteca.Data
{
    // A classe ApplicationDbContext herda de IdentityDbContext, que é uma classe fornecida pelo ASP.NET Core Identity para gerenciar a autenticação e autorização dos usuários.
    public class ApplicationDbContext : IdentityDbContext
    {

        // O construtor da classe recebe um objeto DbContextOptions<ApplicationDbContext> como parâmetro, que é usado para configurar a conexão com o banco de dados e outras opções relacionadas ao contexto.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        // Incluir um Objeto DbSet para cada entidade que você deseja mapear para uma tabela no banco de dados. O DbSet é uma coleção de entidades do tipo especificado, e o Entity Framework Core usará essas propriedades para criar as tabelas correspondentes no banco de dados.
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<LivroGenero> LivrosGeneros { get; set; }
    }
}