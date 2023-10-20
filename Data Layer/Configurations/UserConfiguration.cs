using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tools.Models.Class_Models;

namespace Data_Layer.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users"); 

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(255); 

            builder.Property(u => u.CreatedOn)
                .IsRequired();

            builder.Property(u => u.IsDisabled)
                .IsRequired();

            builder.HasMany(u => u.Polls) 
                .WithOne(p => p.User)     
                .HasForeignKey(p => p.UserId); 

        }
    }
}
