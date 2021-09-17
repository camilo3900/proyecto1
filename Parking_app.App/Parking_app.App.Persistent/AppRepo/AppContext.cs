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
                // Aqui el DataSource es el nombre de la base de datos local
                .UseSqlServer("Initial Catalog = ParkingApp.Data; Data Source=LAPTOP-VPO7HRDD\\SQLEXPRESS; Integrated Security=true");
            }
        }
    }
}