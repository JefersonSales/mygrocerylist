namespace MyGroceryList.Core.Entities;

public class GroceryList : BaseEntity
{
    
    public GroceryList(int idUser, int idCategory)
    {
        IdUser = idUser;
        IdCategory = idCategory;
        Items = new List<GroceryItem>();
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }
    
    public int IdUser { get; private set; }
    public User User { get; private set; }
    public int IdCategory { get; private set; }
    public Category Category { get; private set; }
    public List<GroceryItem> Items { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
    public DateTime? DeletedAt { get; private set; }
    
    public void AddItem(GroceryItem item)
    {
        Items.Add(item);
    }
    
    public void RemoveItem(GroceryItem item)
    {
        Items.Remove(item);
    }
    
    public void UpdateCategory(int idCategory)
    {
        IdCategory = idCategory;
    }
    
    public void UpdateUpdatedAt()
    {
        UpdatedAt = DateTime.UtcNow;
    }
    
    public void Delete()
    {
        DeletedAt = DateTime.UtcNow;
    }
    
    
}