using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Models
{
    public class CRUDeliciousDbContext : DbContext
    {
        public CRUDeliciousDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Dish> Dishes { get; set; }
    }
}