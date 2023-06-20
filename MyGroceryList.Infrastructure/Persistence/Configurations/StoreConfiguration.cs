using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGroceryList.Core.Entities;

namespace MyGroceryList.Infrastructure.Persistence.Configurations;

public class StoreConfiguration : IEntityTypeConfiguration<Store>
{
    public void Configure(EntityTypeBuilder<Store> builder)
    {
        builder.HasKey(s => s.Id);
        
        builder.Property(s => s.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.HasMany(s => s.GroceryItems)
            .WithOne(g => g.Store)
            .HasForeignKey(g => g.StoreId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}