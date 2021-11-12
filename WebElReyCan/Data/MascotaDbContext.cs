using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebElReyCan.Models;

namespace WebElReyCan.Data
{
    public class MascotaDbContext : DbContext
    {
        public MascotaDbContext() : base("KeyDB") { }
        public DbSet<Mascota> Mascotas { get; set; }
    }
}