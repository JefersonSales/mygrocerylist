using System;
namespace MyGroceryList.Application.ViewModels
{
    public class CategoryViewModel
    {
        public CategoryViewModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; private set; }
        
    }
}

