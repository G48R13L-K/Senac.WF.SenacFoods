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
           public DbSet<Usuario> Usuarios { get; set; }
         
           public DbSet<CardapioItem> CardapioItems { get; set; }

           public DbSet<Mesa> Mesas { get; set; }

           public DbSet<Comanda> comandas { get; set; }
    }
}
