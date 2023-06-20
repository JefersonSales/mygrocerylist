using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGroceryList.Core.Entities;

namespace MyGroceryList.Infrastructure.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(u => u.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(u => u.Email);
        builder.Property(u=> u.Password);
        builder.Property(u => u.JoinDate);
        builder.Property(u => u.LastLoginDate);
        
        builder.HasMany(u => u.GroceryLists)
            .WithOne(g => g.User)
            .HasForeignKey(g => g.IdUser)
            .OnDelete(DeleteBehavior.Cascade);
    }
}