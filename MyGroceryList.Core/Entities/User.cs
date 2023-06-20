namespace MyGroceryList.Core.Entities;

public class User : BaseEntity
{
    public User(string name, string email, string password)
    {
        Name = name;
        Email = email;
        Password = password;
        JoinDate = DateTime.Now;
        LastLoginDate = DateTime.Now;
        
        GroceryLists = new List<GroceryList>();
    }
    
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
    public DateTime JoinDate { get; private set; }
    public DateTime LastLoginDate { get; private set; }
    public List<GroceryList> GroceryLists { get; private set; }
    
    
}