using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Drinda_Marius_Lab2.Models;

namespace Drinda_Marius_Lab2.Data
{
    public class Drinda_Marius_Lab2Context : DbContext
    {
        public Drinda_Marius_Lab2Context (DbContextOptions<Drinda_Marius_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Drinda_Marius_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
