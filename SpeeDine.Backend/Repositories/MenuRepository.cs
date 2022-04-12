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
            AddLunchMenu();
            AddKidsMenu();
            AddDessertMenu();
            AddDrinksMenu();
        }

        public void AddDinnerMenu()
        {
            Menu.Add(new MenuItem(IdCounter++, "Bacon Cheddar Burger", "Cured bacon, tomatoes, onion, lettuce, pickles, mayonnaise and mustard, on a toasted brioche bun", 15.75,
                "https://simply-delicious-food.com/wp-content/uploads/2015/07/Bacon-and-cheese-burgers-3.jpg",
                new List<MenuCategory> { MenuCategory.Dinner, MenuCategory.Lunch, MenuCategory.Popular },
                new List<MenuTag> { MenuTag.PeanutFree },
                new List<MenuSide>
                {
                    new MenuSide("Fries", 0),
                    new MenuSide("Yam Fries", 2.50),
                    new MenuSide("Caesar Salad", 2.50),
                    new MenuSide("Chowder", 2.50),
                    new MenuSide("Potato Salad", 2.50)
                }));

            Menu.Add(new MenuItem(IdCounter++, "Impossible Burger", "100% plant-based burger, tomatoes, onions, lettuce, pickles, mayonnaise and mustard, on a toasted brioche bun", 15.75,
               "https://d35y74nlubkiek.cloudfront.net/9d2f91a6-a359-4625-9707-fea3a29b2b19",
               new List<MenuCategory> { MenuCategory.Dinner, MenuCategory.Lunch, MenuCategory.Popular },
               new List<MenuTag> { MenuTag.Vegetarian},
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
              new List<MenuTag> { MenuTag.PeanutFree, MenuTag.KetoFriendly, MenuTag.GlutenFree },
              new List<MenuSide>
              {
                    new MenuSide("Fries", 0),
                    new MenuSide("Mashed Potatoes", 0),
                    new MenuSide("Baked Potato", 0),
                    new MenuSide("Caesar Salad", 2.50),
                    new MenuSide("Chowder", 2.50),
              }));


            Menu.Add(new MenuItem(IdCounter++, "BBQ Ribs", "BBQ sauce on a half rack of ribs and your choice of side", 21.75,
                "https://media-cdn.tripadvisor.com/media/photo-s/1a/62/ea/93/baked-pork-ribs-american.jpg",
              new List<MenuCategory> { MenuCategory.Dinner },
              new List<MenuTag> { MenuTag.PeanutFree, MenuTag.KetoFriendly, MenuTag.GlutenFree },
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
             new List<MenuTag> { MenuTag.PeanutFree, MenuTag.GlutenFree, MenuTag.KetoFriendly }, null));
            
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
             new List<MenuTag> { MenuTag.PeanutFree, MenuTag.GlutenFree, MenuTag.KetoFriendly }, null));
            
            Menu.Add(new MenuItem(IdCounter++, "Pistachio Crusted Salmon", "garlic mashed potato, roasted brussels sprouts, maple butter", 28.75, "https://aubreyskitchen.com/wp-content/uploads/2020/06/pistachio-crusted-salmon-featured.jpg",
            new List<MenuCategory> { MenuCategory.Dinner, MenuCategory.Popular },
            new List<MenuTag> { MenuTag.GlutenFree, MenuTag.KetoFriendly }, null));

            Menu.Add(new MenuItem(IdCounter++, "Ahi Tuna Poke Bowl", "Jasmine rice, soy marinated ahi tuna, avocado, cucumber, radish, mango, macadamia nuts", 18.00,
                "https://d35y74nlubkiek.cloudfront.net/0bc51a9e-3ef9-4fad-b5b9-fa02e3cc777e",
              new List<MenuCategory> { MenuCategory.Dinner, MenuCategory.Lunch, MenuCategory.Popular },
              new List<MenuTag> { MenuTag.PeanutFree, MenuTag.GlutenFree, MenuTag.KetoFriendly }, null));

            Menu.Add(new MenuItem(IdCounter++, "Garlic Prawn Spaghettini", "Chili and clam sauce, herbs, garlic bread", 20.00,
                "https://d35y74nlubkiek.cloudfront.net/aad94be7-21e6-4dbc-89e0-67203e093d68",
              new List<MenuCategory> { MenuCategory.Dinner, MenuCategory.Popular },
              new List<MenuTag> { MenuTag.PeanutFree}, null));
        }

        public void AddAppetizerMenu()
        {
            Menu.Add(new MenuItem(IdCounter++, "Chicken Karaage", "Ginger + garlic marinated chicken, pickled red onion, radish, togarashi mayonnaise", 17.75,
              "https://d35y74nlubkiek.cloudfront.net/8417f70d-ef7a-437b-9600-fe3a781080fd",
              new List<MenuCategory> { MenuCategory.Appetizer, MenuCategory.Popular },
              new List<MenuTag> { MenuTag.PeanutFree }, null));

            Menu.Add(new MenuItem(IdCounter++, "Chipotle Calamari", "Chipotle aioli, jalapeño, pickled onion, asparagus", 15.00,
              "https://d35y74nlubkiek.cloudfront.net/8705c946-d16c-4e72-a736-d15e290865ba",
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

            Menu.Add(new MenuItem(IdCounter++, "Caesar Salad", "romaine, aged parmesan cheese, creamy dressing", 11.00,
           "https://popmenucloud.com/cdn-cgi/image/width=1200,height=1200,fit=scale-down,format=auto,quality=60/bzsancfv/3c7e7199-3083-489d-8fde-1905ba8e9155",
           new List<MenuCategory> { MenuCategory.Appetizer },
           new List<MenuTag> { MenuTag.GlutenFree }, null));

            Menu.Add(new MenuItem(IdCounter++, "Bruschetta", "Grilled country bread with Roma tomatoes, olive oil, garlic and basil.", 8.95,
           "https://www.giallozafferano.com/images/229-22900/tomato-bruschetta_650x433_wm.jpg",
           new List<MenuCategory> { MenuCategory.Appetizer },
           new List<MenuTag> { MenuTag.PeanutFree, MenuTag.Vegetarian, MenuTag.Vegan }, null));

            Menu.Add(new MenuItem(IdCounter++, "Stuffed Mushrooms", "Mushrooms caps baked with a filling of three choice cheeses, tomatoes, and chickpeas.", 8.95,
          "https://img.buzzfeed.com/thumbnailer-prod-us-east-1/63229507a88547f1be1e86e23816c5fe/BFV7241_Garlic_Parmesan-Stuffed_Mushrooms-fb1080.jpg",
          new List<MenuCategory> { MenuCategory.Appetizer },
          new List<MenuTag> { MenuTag.PeanutFree, MenuTag.Vegetarian, MenuTag.KetoFriendly, MenuTag.GlutenFree }, null));

            Menu.Add(new MenuItem(IdCounter++, "French Onion Soup", "beef broth, sherry, spanish onion, swiss and parmesan cheese", 5.50,
          "https://kristineskitchenblog.com/wp-content/uploads/2021/05/french-onion-soup-1200-square-122.jpg",
          new List<MenuCategory> { MenuCategory.Appetizer },
          new List<MenuTag> { MenuTag.PeanutFree }, null));
        }

        public void AddLunchMenu()
        {
            Menu.Add(new MenuItem(IdCounter++, "Fish and Chips", "golden ale battered ling cod, tartar sauce, grilled lemon, pub chips", 13.75,
              "https://static.toiimg.com/thumb/59736398.cms?width=1200&height=900",
            new List<MenuCategory> { MenuCategory.Lunch, MenuCategory.Popular , MenuCategory.Dinner },
            new List<MenuTag> { MenuTag.PeanutFree },
            new List<MenuSide>
            {
                    new MenuSide("Fries", 0),
                    new MenuSide("Sweet Potato Fries", 2.50),
                    new MenuSide("Truffle Fries", 2.50),
            }));

            Menu.Add(new MenuItem(IdCounter++, "Turkey Reuben Sandwich", "shaved smoked turkey, sauerkraut, swiss cheese, thousand island dressing, light rye", 10.75,
             "https://zestfulkitchen.com/wp-content/uploads/2021/04/turkey-reuben_for-web-3.jpg",
           new List<MenuCategory> { MenuCategory.Lunch },
           new List<MenuTag> { MenuTag.PeanutFree },
           new List<MenuSide>
           {
                    new MenuSide("Fries", 0),
                    new MenuSide("Sweet Potato Fries", 2.50),
                    new MenuSide("Truffle Fries", 2.50),
           }));

            Menu.Add(new MenuItem(IdCounter++, "BLT Sandwich", "Bacon, lettuce, tomato, and mayonaise", 10.75,
            "https://tmbidigitalassetsazure.blob.core.windows.net/rms3-prod/attachments/37/1200x1200/Loaded-Avocado-BLT_EXPS_SDAS17_198564_D04_04_3b.jpg",
          new List<MenuCategory> { MenuCategory.Lunch },
          new List<MenuTag> { MenuTag.PeanutFree },
          new List<MenuSide>
          {
                    new MenuSide("Fries", 0),
                    new MenuSide("Sweet Potato Fries", 2.50),
                    new MenuSide("Truffle Fries", 2.50),
          }));

            Menu.Add(new MenuItem(IdCounter++, "Lettuce Wraps", "chicken, sweet chili, crispy wonton, radish, cilantro, pistachio tahini dressing", 13.75,
            "https://www.yummyhealthyeasy.com/wp-content/uploads/2019/03/lettuce-wraps-recipe-1.jpg",
          new List<MenuCategory> { MenuCategory.Lunch },
          new List<MenuTag> { MenuTag.KetoFriendly }, null));

        }

        public void AddKidsMenu()
        {
            Menu.Add(new MenuItem(IdCounter++, "Chicken Tenders", "Antibiotic and hormone-free chicken served with veggies or fries", 8.75,
              "https://www.prairiedogbrewing.ca/wp-content/uploads/2021/03/MG_4168-scaled.jpg",
            new List<MenuCategory> { MenuCategory.Kids },
            new List<MenuTag> { MenuTag.PeanutFree },
            new List<MenuSide>
            {
                            new MenuSide("Fries", 0),
                            new MenuSide("Veggies", 0),
            }));

            Menu.Add(new MenuItem(IdCounter++, "Grilled Cheese", "American cheese on toasted bread", 8.75,
            "https://highlights0.azureedge.net/sites/default/files/public/grilled-cheese_istock-508897546_lauripatterson.jpg",
          new List<MenuCategory> { MenuCategory.Kids },
          new List<MenuTag> { MenuTag.PeanutFree },
          new List<MenuSide>
          {
                new MenuSide("Fries", 0),
                new MenuSide("Veggies", 0),
          }));

            Menu.Add(new MenuItem(IdCounter++, "Mac & Cheese", "Classic macaroni noodles with a creamy cheese sauce topped with toasted breadcrumbs.", 8.75,
           "http://somethingedible.com/images/uploads/recipes/SomethingEdible-Stove_Top_One_Pot_Macaroni_and_Cheese.jpg",
         new List<MenuCategory> { MenuCategory.Kids },
         new List<MenuTag> { MenuTag.PeanutFree },
         new List<MenuSide>
         {
                new MenuSide("Fries", 0),
                new MenuSide("Veggies", 0),
         }));
        }

        public void AddDessertMenu()
        {
            Menu.Add(new MenuItem(IdCounter++, "NYC Cheesecake", "Graham cracker crust, fresh berries, whipped chantilly cream", 11.75, "https://d35y74nlubkiek.cloudfront.net/3a9eaab0-369a-4c63-90fa-e440345e7a24",
                      new List<MenuCategory> { MenuCategory.Dessert },
                      new List<MenuTag> { MenuTag.PeanutFree }, null));
            Menu.Add(new MenuItem(IdCounter++, "Sticky Toffee Chocolate Pudding", "Warm pudding cake, chocolate and toffee sauces, vanilla ice cream, maple crumble", 10.75, "https://d35y74nlubkiek.cloudfront.net/8e600ee8-0b11-4b5a-bac1-e131ca15a409",
                new List<MenuCategory> { MenuCategory.Dessert },
                new List<MenuTag> { MenuTag.PeanutFree }, null));
        }

        public void AddDrinksMenu()
        {
            Menu.Add(new MenuItem(IdCounter++, "Coke", "A can of coke with ice", 2.00, "https://www.krqe.com/wp-content/uploads/sites/12/2021/07/Coke-Zero-Sugar-Table-Top.jpg?w=1280",
           new List<MenuCategory> { MenuCategory.Drinks },
           new List<MenuTag> { MenuTag.PeanutFree }, null));

            Menu.Add(new MenuItem(IdCounter++, "Moscow Mule", "Smirnoff vodka, ginger and fresh lime", 11.75, "https://d35y74nlubkiek.cloudfront.net/d7818dcf-39a8-4656-a42c-2f727f12ccd8",
               new List<MenuCategory> { MenuCategory.Drinks },
               new List<MenuTag> { MenuTag.PeanutFree }, null, true));
          
            Menu.Add(new MenuItem(IdCounter++, "White Negroni", "Tanqueray gin, St Germain Elderflower, Dolin dry vermouth, Yellow Chartruese, and Lemon oil - 2.5oz", 14.25, "	https://d35y74nlubkiek.cloudfront.net/e5882808-6e47-4530-83f4-5c678ce9ff9e",
             new List<MenuCategory> { MenuCategory.Drinks },
             new List<MenuTag> { MenuTag.PeanutFree }, null, true));

            Menu.Add(new MenuItem(IdCounter++, "Margarita", "olmeca, cointreau, agave, lemon, lime", 10.25, "https://www.thespruceeats.com/thmb/FjeGodPqSKCTiodzzURclGz9Jag=/3200x2136/filters:fill(auto,1)/fresh-margarita-cocktail-recipe-759317-step-05-dae71772c4304cf7911489a1c7d219ab.jpg",
            new List<MenuCategory> { MenuCategory.Drinks },
            new List<MenuTag> { MenuTag.PeanutFree }, null, true));

            Menu.Add(new MenuItem(IdCounter++, "Mojito", "havana club, lemon, lime, mint, soda", 10.25,
                "https://cookieandkate.com/images/2020/08/best-mojito-recipe-2.jpg",
           new List<MenuCategory> { MenuCategory.Drinks },
           new List<MenuTag> { MenuTag.PeanutFree }, null, true));
        }

        #endregion


    }
}
