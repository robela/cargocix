using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AngularJSAuthentication.API.Models.Mapping
{
    public class BookingMap : EntityTypeConfiguration<Booking>
    {
        public BookingMap()
        {
            // Primary Key
            this.HasKey(t => t.bookingsId);

            // Properties
            this.Property(t => t.location)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Bookings");
            this.Property(t => t.bookingsId).HasColumnName("bookingsId");
            this.Property(t => t.arrivalTime).HasColumnName("arrivalTime");
            this.Property(t => t.location).HasColumnName("location");
            this.Property(t => t.userId).HasColumnName("userId");
        }
    }
}
