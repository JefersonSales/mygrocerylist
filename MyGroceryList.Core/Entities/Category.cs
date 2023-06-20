namespace MyGroceryList.Core.Entities;

public class Category : BaseEntity
{
    public Category(string name)
    {
        Name = name;
        GroceryItem = new List<GroceryItem>();
    }
    public string Name { get; private set; }
    public List<GroceryItem> GroceryItem { get; private set; }
    
    public void UpdateName(string name)
    {
        Name = name;
    }
}