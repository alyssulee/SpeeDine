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
        private int IdCounter = 0;

        public MenuRepository()
        {
            PopulateMenuRepo();
        }

        public MenuItem? GetItemByID(int id)
        {
            return Menu.FirstOrDefault(item => item.Id == id);
        }

        public List<MenuItem> GetMenuByCategory(MenuCategory category)
        {
            var filtered = new List<MenuItem>();
            foreach (var item in Menu)
            {
                if (item.Categories.Contains(category))
                    filtered.Add(item);
            }
            return filtered;
        }


        #region PopulateMenuRepo
        private void PopulateMenuRepo()
        {
            Menu.Clear();
            AddDinnerMenu();
            AddAppetizerMenu();
            AddDessertMenu();
            AddDrinksMenu();
        }

        public void AddDinnerMenu()
        {
            Menu.Add(new MenuItem(IdCounter++, "Bacon Cheddar Burger", "Cured bacon, tomatoes, onion, lettuce, pickles, mayonnaise and mustard, on a toasted brioche bun", 21.75,
                "https://simply-delicious-food.com/wp-content/uploads/2015/07/Bacon-and-cheese-burgers-3.jpg",
                new List<MenuCategory> { MenuCategory.Dinner, MenuCategory.Popular },
                new List<MenuTag> { MenuTag.PeanutFree },
                new List<MenuSide>
                {
                    new MenuSide("Fries", 0),
                    new MenuSide("Yam Fries", 2.50),
                    new MenuSide("Caesar Salad", 2.50),
                    new MenuSide("Chowder", 2.50),
                    new MenuSide("Potato Salad", 2.50)
                }));
            
            Menu.Add(new MenuItem(IdCounter++, "6 oz Canadian Prime Sirloin", "Served with seasonal vegetables and your choice of side", 32.75,
                "https://mytbones.com/wp-content/uploads/2018/11/AAA-Top-Sirloin.jpg",
              new List<MenuCategory> { MenuCategory.Dinner },
              new List<MenuTag> { MenuTag.PeanutFree },
              new List<MenuSide>
              {
                    new MenuSide("Fries", 0),
                    new MenuSide("Mashed Potatoes", 0),
                    new MenuSide("Baked Potato", 0),
                    new MenuSide("Caesar Salad", 2.50),
                    new MenuSide("Chowder", 2.50),
              }));
            
            Menu.Add(new MenuItem(IdCounter++, "Grilled Chicken Breast", "Topped with forrester wild mushroom mix, fine herbs, roast potato, fresh vegetables", 18.25,
               "https://media.istockphoto.com/photos/gourmet-dijon-chicken-breast-with-thyme-and-potatoes-picture-id1203256503?s=612x612",
             new List<MenuCategory> { MenuCategory.Dinner },
             new List<MenuTag> { MenuTag.PeanutFree, MenuTag.GlutenFree }, null));
            
            Menu.Add(new MenuItem(IdCounter++, "Street Chicken Tacos", "Flour tortillas, white cheddar, cabbage, jalapeño crema, slow roasted achiote chicken, cilantro, fresh cut salsa", 15.75,
                "https://d35y74nlubkiek.cloudfront.net/b84218d1-b6c2-4be3-8ee7-9d4abb7a4278",
              new List<MenuCategory> { MenuCategory.Dinner, MenuCategory.Popular },
              new List<MenuTag> { MenuTag.PeanutFree },
              new List<MenuSide>
              {
                    new MenuSide("Fries", 0),
                    new MenuSide("Sweet Potato Fries", 2.50),
                    new MenuSide("Truffle Fries", 2.50),
              }));

            Menu.Add(new MenuItem(IdCounter++, "Oven Roasted Salmon", "Feta, caper and dill aioli or blackened with confit garlic butter served with jasmine rice and seasonal vegetables", 28.75, "https://d35y74nlubkiek.cloudfront.net/39ec36b9-1d3d-4b9e-8001-f1aa7403e304",
             new List<MenuCategory> { MenuCategory.Dinner, MenuCategory.Popular },
             new List<MenuTag> { MenuTag.PeanutFree, MenuTag.GlutenFree }, null));

        }

        public void AddAppetizerMenu()
        {
            Menu.Add(new MenuItem(IdCounter++, "Chicken Karaage", "Ginger + garlic marinated chicken, pickled red onion, radish, togarashi mayonnaise", 17.75,
              "https://d35y74nlubkiek.cloudfront.net/8417f70d-ef7a-437b-9600-fe3a781080fd",
              new List<MenuCategory> { MenuCategory.Appetizer, MenuCategory.Popular },
              new List<MenuTag> { MenuTag.PeanutFree }, null));

            Menu.Add(new MenuItem(IdCounter++, "Shrimp Cocktail", "Chilled jumbo shrimp, martini cocktail sauce", 15.75,
             "https://www.fallsviewboulevard.com/wp-content/uploads/2016/10/KegSteakhouse6.jpg",
             new List<MenuCategory> { MenuCategory.Appetizer},
             new List<MenuTag> { MenuTag.PeanutFree, MenuTag.GlutenFree }, null));

            Menu.Add(new MenuItem(IdCounter++, "Mixed Green Salad", "field greens, garden vegetables, vinaigrette dressing", 11.00,
            "https://lh3.googleusercontent.com/zAGhhQMqBfNC_68b7OJYomeowWiQksg9fa9M9Tj70aQT2_YA1SE6NTigJ27LOI2fJzOslxdFENfxHQUm73o9=w1280-h960-c-rj-v1-e365",
            new List<MenuCategory> { MenuCategory.Appetizer },
            new List<MenuTag> { MenuTag.PeanutFree, MenuTag.GlutenFree, MenuTag.Vegetarian, MenuTag.Vegan }, null));
        }

        public void AddDessertMenu()
        {

        }

        public void AddDrinksMenu()
        {

        }

        #endregion


    }
}
