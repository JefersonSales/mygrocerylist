using System;
using MyGroceryList.Core.Entities;

namespace MyGroceryList.Application.ViewModels
{
    public class CategoryDetailsViewModel
    {
        public CategoryDetailsViewModel(int id, string name, List<GroceryItem> groceryItem)
        {
            Id = id;
            Name = name;
            GroceryItem = groceryItem.Select(g => $"{g.Store.Name}").ToList();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> GroceryItem { get; private set; }
    }
}

