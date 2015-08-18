using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AngularJSAuthentication.API.Models.Mapping
{
    public class ReceiptDelayMap : EntityTypeConfiguration<ReceiptDelay>
    {
        public ReceiptDelayMap()
        {
            // Primary Key
            this.HasKey(t => t.receiptDelayId);

            // Properties
            this.Property(t => t.receiptDelayId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ReceiptDelay");
            this.Property(t => t.receiptDelayId).HasColumnName("receiptDelayId");
            this.Property(t => t.reasonId).HasColumnName("reasonId");
            this.Property(t => t.bookingsId).HasColumnName("bookingsId");
            this.Property(t => t.newArrivalTime).HasColumnName("newArrivalTime");
            this.Property(t => t.textMsg).HasColumnName("textMsg");
            // Relationships
            //this.HasOptional(t => t.Booking)
            //    .WithMany(t => t.ReceiptDelays)
            //    .HasForeignKey(d => d.bookingsId);
            //this.HasOptional(t => t.Reason)
            //    .WithMany(t => t.ReceiptDelays)
            //    .HasForeignKey(d => d.reasonId);

        }
    }
}
