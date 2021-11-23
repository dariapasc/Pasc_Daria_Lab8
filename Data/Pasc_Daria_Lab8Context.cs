using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pasc_Daria_Lab8.Models;

namespace Pasc_Daria_Lab8.Data
{
    public class Pasc_Daria_Lab8Context : DbContext
    {
        public Pasc_Daria_Lab8Context (DbContextOptions<Pasc_Daria_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Pasc_Daria_Lab8.Models.Book> Book { get; set; }

        public DbSet<Pasc_Daria_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Pasc_Daria_Lab8.Models.Category> Category { get; set; }
    }
}
