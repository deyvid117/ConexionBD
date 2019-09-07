using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConexionBD.models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        
        public DbSet<invoice> invoices { get; set; }

    }
}