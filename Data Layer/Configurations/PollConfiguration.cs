using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tools.Models.Class_Models;

namespace Data_Layer.Configurations
{
    public class PollConfiguration : IEntityTypeConfiguration<Poll>
    {
        public void Configure(EntityTypeBuilder<Poll> builder)
        {
            builder
                .HasOne(p => p.User)
                .WithMany(u => u.Polls)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(p => p.Choices)
                .WithOne(c => c.Poll)
                .HasForeignKey(c => c.PollId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
