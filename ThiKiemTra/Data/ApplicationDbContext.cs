using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThiKiemTra.Models;

namespace ThiKiemTra.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Huyen> huyens { get; set; }
        public DbSet<Tinh> tinhs { get; set; }
        public DbSet<User> users { get; set; }
    }
}
