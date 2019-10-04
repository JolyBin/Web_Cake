using DataBase.DataBase.Entites;
using DataBase.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase
{
    public class EFDBContext: DbContext
    {
        public DbSet<TypeIng> Type { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }

        public DbSet<Design> Design { get; set; }

        public DbSet<Cake> Cake { get; set; }

        public DbSet<Blank> Blank { get; set; }

        public DbSet<Client> Client { get; set; }

        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options)
        {

        }
    }


    /// <summary>
    /// For Migrations
    /// </summary>

    public class EFDBContextFactory: IDesignTimeDbContextFactory<EFDBContext>
    {
        public EFDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EFDBContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DataBase;Trusted_Connection=True;MultipleActiveResultSets=true", b => b.MigrationsAssembly("DataBase"));

            return new EFDBContext(optionsBuilder.Options);
        }
    }
}
