using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SenacFoods
{
    public class ComandaDBContest:DbContext
    {
        //1 construtor do banco de dados
        public ComandaDBContest() : base()
        {
            
        }

        //2 configurar conexão
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conexao = "Server=localhost;Database=SenacFoods;User=root;Password=";
            optionsBuilder.UseMySql(conexao, ServerVersion.AutoDetect(conexao));
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Usuario> Usuarios { get; set; }
         
           public DbSet<CardapioItem> CardapioItems { get; set; }

           public DbSet<Mesa> Mesas { get; set; }

           public DbSet<Comanda> Comandas { get; set; }

           public DbSet<ComandaItem> ComandaItems { get; set; }
    
           public DbSet<PedidoCozinha> PedidoCozinhas { get; set; }
        
           public DbSet<PedidoCozinhaItem> PedidoCozinhaItems { get; set; }
    }
}
