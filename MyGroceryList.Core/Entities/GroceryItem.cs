namespace MyGroceryList.Core.Entities;

public class GroceryItem : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int BrandId { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public int StoreId { get; set; }
    public Store Store { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public bool IsFavorite { get; set; }
    
    public bool IsDeleted { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
}