using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFÖdev.Models
{
    public class EFÖdevContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=EFOdevCommerceDb; Trusted_Connection=True");
        }

        public DbSet<Supplier> Suppliers { get; set; }
    }
}
