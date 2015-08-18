using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AngularJSAuthentication.API.Models.Mapping
{
    public class MessageMap : EntityTypeConfiguration<Message>
    {
        public MessageMap()
        {
            // Primary Key
            this.HasKey(t => t.messageId);

            // Properties
            this.Property(t => t.message1)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Message");
            this.Property(t => t.messageId).HasColumnName("messageId");
            this.Property(t => t.bookingsId).HasColumnName("bookingsId");
            this.Property(t => t.message1).HasColumnName("message");

            // Relationships
            //this.HasOptional(t => t.Booking)
            //    .WithMany(t => t.Messages)
            //    .HasForeignKey(d => d.bookingsId);

        }
    }
}
