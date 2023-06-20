namespace MyGroceryList.Core.Entities;

public class Store : BaseEntity
{
    public string Name { get; private set; }
    public List<GroceryItem> GroceryItems { get; private set; }
}