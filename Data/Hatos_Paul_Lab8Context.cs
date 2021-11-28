using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hatos_Paul_Lab8.Models;

namespace Hatos_Paul_Lab8.Data
{
    public class Hatos_Paul_Lab8Context : DbContext
    {
        public Hatos_Paul_Lab8Context (DbContextOptions<Hatos_Paul_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Hatos_Paul_Lab8.Models.Book> Book { get; set; }

        public DbSet<Hatos_Paul_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Hatos_Paul_Lab8.Models.Category> Category { get; set; }
    }
}
