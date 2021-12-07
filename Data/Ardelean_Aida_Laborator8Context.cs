using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ardelean_Aida_Laborator8.Models;

namespace Ardelean_Aida_Laborator8.Data
{
    public class Ardelean_Aida_Laborator8Context : DbContext
    {
        public Ardelean_Aida_Laborator8Context (DbContextOptions<Ardelean_Aida_Laborator8Context> options)
            : base(options)
        {
        }

        public DbSet<Ardelean_Aida_Laborator8.Models.Book> Book { get; set; }

        public DbSet<Ardelean_Aida_Laborator8.Models.Publisher> Publisher { get; set; }

        public DbSet<Ardelean_Aida_Laborator8.Models.Category> Category { get; set; }
    }
}
