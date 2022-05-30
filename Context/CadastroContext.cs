using FlixPrime.Model;
using Microsoft.EntityFrameworkCore;

namespace FlixPrime.Context
{
  public class CadastroContext : DbContext
  {
    // public CadastroContext(DbContextOptions<CadastroContext> options) : base(options) { }
    public DbSet<Cadastro> Cadastros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Data Source=FlixPrime.db");
    }

  }
}