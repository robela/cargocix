using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AngularJSAuthentication.API.Models.Mapping;
using Microsoft.AspNet.Identity.EntityFramework;
using AngularJSAuthentication.API.Entities;

namespace AngularJSAuthentication.API.Models
{
    public partial class CargoclixContext : DbContext
    {
        static CargoclixContext()
        {
            Database.SetInitializer<CargoclixContext>(null);
        }

        public CargoclixContext()
            : base("Name=CargoclixContext")
        {
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<OnMyWay> OnMyWays { get; set; }
        public DbSet<Reason> Reasons { get; set; }
        public DbSet<ReceiptDelay> ReceiptDelays { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookingMap());
            modelBuilder.Configurations.Add(new MessageMap());
            modelBuilder.Configurations.Add(new OnMyWayMap());
            modelBuilder.Configurations.Add(new ReasonMap());
            modelBuilder.Configurations.Add(new ReceiptDelayMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
