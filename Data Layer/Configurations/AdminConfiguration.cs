using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tools.Models.Class_Models;

namespace Data_Layer.EntityConfigurations
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            
            builder.ToTable("Admins");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Level)
                .IsRequired();

            builder.Property(a => a.IsDisabled)
                .IsRequired();

        }
    }
}
