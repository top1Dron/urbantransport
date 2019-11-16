namespace Urban_Transport
{
    using System.Data.Entity;
    using Urban_Transport.Entities;

    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<StopStation> StopStations { get; set; }

        public DbSet<Driver> Drivers { get; set; }

        public DbSet<TransportType> TransportTypes { get; set; }

        public DbSet<DriverRoutes> DriversRoutes { get; set; }

        public DbSet<Route> Routes { get; set; }

        public DbSet<RoutesWork> RoutesWorks { get; set; }
    }
}
