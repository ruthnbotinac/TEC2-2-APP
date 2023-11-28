using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application;

namespace InventariococinaWebApplication.Data
{
    public class InventariococinaWebApplicationContext : DbContext
    {
        public InventariococinaWebApplicationContext (DbContextOptions<InventariococinaWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Application.Usuario> Usuario { get; set; } = default!;
    }
}
