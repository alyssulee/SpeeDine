using SpeeDine.Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeeDine.Backend.Repositories
{
    public class MenuRepository
    {
        public List<MenuItem> Menu = new();
        public MenuRepository()
        {
            PopulateMenuRepo();
        }

        private void PopulateMenuRepo()
        {
            // Dinner
            Menu.Add(new MenuItem(1, "Bacon Cheddar Burger", "Cured bacon, tomatoes, onion, lettuce, pickles, mayonnaise and mustard, on a toasted brioche bun", 21.75, 
                new List<MenuCategory> { MenuCategory.Dinner }, 
                new List<MenuTags> { MenuTags.PeanutFree }, 
                new List<MenuSide>
                {
                    new MenuSide("Fries", 0),
                    new MenuSide("Yam Fries", 2.50),
                    new MenuSide("Caesar Salad", 2.50),
                    new MenuSide("Chowder", 2.50),
                    new MenuSide("Potato Salad", 2.50)
                }));
            Menu.Add(new MenuItem(2, "6 oz Canadian Prime Sirloin", "Served with seasonal vegetables", 32.75,
              new List<MenuCategory> { MenuCategory.Dinner },
              new List<MenuTags> { MenuTags.PeanutFree },
              new List<MenuSide>
              {
                    new MenuSide("Fries", 0),
                    new MenuSide("Mashed Potatoes", 0),
                    new MenuSide("Baked Potatoe", 0),
                    new MenuSide("Caesar Salad", 2.50),
                    new MenuSide("Chowder", 2.50),
              }));
        }

        public MenuItem? GetItemByID(int id)
        {
           return Menu.FirstOrDefault(item => item.Id == id);
        }
    }
}
