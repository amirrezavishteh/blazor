using Microsoft.EntityFrameworkCore;
using P8.Server.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P8.Shared;


namespace P8.Server.DB
{
    public class ClotheDbContext : DbContext
    {
        public ClotheDbContext(DbContextOptions<ClotheDbContext> options)
            : base(options)
        {}
        public DbSet<Clothe> Clothes {get; set;}
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}