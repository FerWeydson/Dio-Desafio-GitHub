using Microsoft.EntityFrameworkCore;
using WebMVCMySQL.Models;

namespace WebMVCMySQL.Context
{
    public class Context : DbContext   //configuração de tabela com link e ligação com banco  de dados
    {
        public Context(DbContextOptions <Context> options)
            : base(options)   //referenciar o contexto com string de conexao
        {
        
        }    
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
