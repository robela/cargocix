using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace AngularJSAuthentication.API.Models.Mapping
{
    public class ReasonMap : EntityTypeConfiguration<Reason>
    {
        public ReasonMap()
        {
            // Primary Key
            this.HasKey(t => t.reasonId);

            // Properties
            this.Property(t => t.name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Reason");
            this.Property(t => t.reasonId).HasColumnName("reasonId");
            this.Property(t => t.name).HasColumnName("name");
        }
    }
}
