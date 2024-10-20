using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Perijoc_Ana_Lab2.Models;

namespace Perijoc_Ana_Lab2.Data
{
    public class Perijoc_Ana_Lab2Context : DbContext
    {
        public Perijoc_Ana_Lab2Context (DbContextOptions<Perijoc_Ana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Perijoc_Ana_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Perijoc_Ana_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        
    }
}
