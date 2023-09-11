using ListaDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaDeContatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<TarefaModel> Tarefa { get; set; }
    }
}
