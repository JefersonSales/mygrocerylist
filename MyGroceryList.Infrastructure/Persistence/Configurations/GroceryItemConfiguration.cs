using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGroceryList.Core.Entities;

namespace MyGroceryList.Infrastructure.Persistence.Configurations;

public class GroceryItemConfiguration : IEntityTypeConfiguration<GroceryItem>
{
    public void Configure(EntityTypeBuilder<GroceryItem> builder)
    {
        builder.HasKey(g => g.Id);
         
        builder.Property(g => g.Name)
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(g => g.Description)
            .HasMaxLength(200);

        builder.HasOne(g => g.Category)
            .WithMany(c => c.GroceryItem)
            .HasForeignKey(g => g.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(g => g.Store)
            .WithMany(s => s.GroceryItems)
            .HasForeignKey(g => g.StoreId);

        builder.Property(g => g.Quantity)
            .IsRequired();

        builder.Property(g => g.Price)
            .HasPrecision(18, 2)
            .IsRequired();

        builder.Property(g => g.CategoryId)
            .IsRequired();

        builder.Property(g => g.IsDeleted);
        builder.Property(g => g.IsFavorite);
        builder.Property(g => g.CreatedDate);
        builder.Property(g => g.UpdatedDate);
        builder.Property(g => g.DeletedDate);
        
        builder.HasIndex(g => g.CategoryId, "IX_GroceryItem_CategoryId")
            .IsUnique();
        builder.HasIndex(g => g.StoreId, "IX_GroceryItem_StoreId")
            .IsUnique();
        
    }
}