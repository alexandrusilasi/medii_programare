using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Silasi_Alexandru_Lab2.Models;

namespace Silasi_Alexandru_Lab2.Data
{
    public class Silasi_Alexandru_Lab2Context : DbContext
    {
        public Silasi_Alexandru_Lab2Context (DbContextOptions<Silasi_Alexandru_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Silasi_Alexandru_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Silasi_Alexandru_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Silasi_Alexandru_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Silasi_Alexandru_Lab2.Models.Category>? Category { get; set; }
    }
}
