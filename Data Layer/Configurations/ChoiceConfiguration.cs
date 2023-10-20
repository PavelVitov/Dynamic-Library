using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tools.Models.Class_Models;

namespace Data_Layer.Configurations
{
    public class ChoiceConfiguration : IEntityTypeConfiguration<Choice>
    {
        public void Configure(EntityTypeBuilder<Choice> builder)
        {
            builder.ToTable("Choices"); 

            builder.HasKey(c => c.Id); 

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255); 

            builder.Property(c => c.Description)
                .HasMaxLength(1000); 

            builder.HasOne(c => c.Poll)
                    .WithMany(p => p.Choices)
                    .HasForeignKey(c => c.PollId);

        }
    }
}
