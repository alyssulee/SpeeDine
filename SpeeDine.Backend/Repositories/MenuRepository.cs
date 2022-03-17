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
                "https://simply-delicious-food.com/wp-content/uploads/2015/07/Bacon-and-cheese-burgers-3-500x375.jpg",
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
            Menu.Add(new MenuItem(2, "6 oz Canadian Prime Sirloin", "Served with seasonal vegetables and your choice of side", 32.75, 
                "https://mytbones.com/wp-content/uploads/2018/11/AAA-Top-Sirloin.jpg",
              new List<MenuCategory> { MenuCategory.Dinner },
              new List<MenuTags> { MenuTags.PeanutFree },
              new List<MenuSide>
              {
                    new MenuSide("Fries", 0),
                    new MenuSide("Mashed Potatoes", 0),
                    new MenuSide("Baked Potato", 0),
                    new MenuSide("Caesar Salad", 2.50),
                    new MenuSide("Chowder", 2.50),
              }));
            Menu.Add(new MenuItem(3, "Grilled Chicken Breast", "Topped with forrester wild mushroom mix, fine herbs, roast potato, fresh vegetables", 18.25,
               "https://media.istockphoto.com/photos/gourmet-dijon-chicken-breast-with-thyme-and-potatoes-picture-id1203256503?s=612x612",
             new List<MenuCategory> { MenuCategory.Dinner },
             new List<MenuTags> { MenuTags.PeanutFree }, null));
            Menu.Add(new MenuItem(4, "Street Chicken Tacos", "Flour tortillas, white cheddar, cabbage, jalapeño crema, slow roasted achiote chicken, cilantro, fresh cut salsa", 15.75,
                "https://d35y74nlubkiek.cloudfront.net/b84218d1-b6c2-4be3-8ee7-9d4abb7a4278",
              new List<MenuCategory> { MenuCategory.Dinner },
              new List<MenuTags> { MenuTags.PeanutFree },
              new List<MenuSide>
              {
                    new MenuSide("Fries", 0),
                    new MenuSide("Sweet Potato Fries", 2.50),
                    new MenuSide("Truffle Fries", 2.50),
              }));
        }

        public MenuItem? GetItemByID(int id)
        {
           return Menu.FirstOrDefault(item => item.Id == id);
        }
    }
}
