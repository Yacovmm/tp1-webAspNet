using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Amigo> Amigos { get; set; }


        public AppDbContext() : base("DefaultConnection")
        {
            Database.SetInitializer<AppDbContext>(
                new CreateDatabaseIfNotExists<AppDbContext>());
            Database.Initialize(false);
        }

        

        public static AppDbContext Create()
        {
            return new AppDbContext();
        }

    }
}
