using Microsoft.EntityFrameworkCore;
using Parking_app.App.Domain;

namespace Parking_app.App.Persistent
{
    public class AppContext : DbContext
    {
        public DbSet <Persona> Personas {get; set;}
        public DbSet <Administrativo> Administrativos {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLocalDB; Initial Catalog = ParkingApp.Data");
            }
        }
    }
}