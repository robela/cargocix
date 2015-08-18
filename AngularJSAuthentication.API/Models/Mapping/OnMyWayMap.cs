using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AngularJSAuthentication.API.Models.Mapping
{
    public class OnMyWayMap : EntityTypeConfiguration<OnMyWay>
    {
        public OnMyWayMap()
        {
            // Primary Key
            this.HasKey(t => t.onMyWayId);

            // Properties
            // Table & Column Mappings
            this.ToTable("OnMyWay");
            this.Property(t => t.onMyWayId).HasColumnName("onMyWayId");
            this.Property(t => t.bookingsId).HasColumnName("bookingsId");

            // Relationships
            //this.HasOptional(t => t.Booking)
            //    .WithMany(t => t.OnMyWays)
            //    .HasForeignKey(d => d.bookingsId);

        }
    }
}
