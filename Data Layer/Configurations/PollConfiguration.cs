using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tools.Models.Class_Models;

namespace Data_Layer.EntityConfigurations
{
    public class PollConfiguration : IEntityTypeConfiguration<Poll>
    {
        public void Configure(EntityTypeBuilder<Poll> builder)
        {
            builder.ToTable("Polls"); 

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(p => p.Description)
                .HasMaxLength(1000);

            builder.Property(p => p.CreateDate)
                .IsRequired();
      
            builder.Property(p => p.IsPrivate)
                .IsRequired();

            builder.HasMany(p => p.Choices)
                .WithOne(c => c.Poll)
                .HasForeignKey(c => c.PollId); 


        }
    }
}
