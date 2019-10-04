using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBase.DataBase.Entites;

namespace Cake.Models
{
    public class UserContext: DbContext
    {
        public DbSet<Client> Users { get; set; }
        public UserContext(DbContextOptions<UserContext> options)
    : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
