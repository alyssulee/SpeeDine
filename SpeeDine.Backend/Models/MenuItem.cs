using System.Collections.Generic;

namespace SpeeDine.Backend.Models
{
    public enum MenuCategory
    {
        Pinned,
        Popular,
        Appetizer,
        Dinner,
        Lunch,
        Dessert,
        Kids,
        Drinks
    }

    public enum MenuTags
    {
        Vegetarian,
        Vegan,
        GlutenFree,
        PeanutFree,
        KetoFriendly
    }

    public record MenuItem (int Id, string Name, string Description, double Price, List<MenuCategory> Categories, List<MenuTags> ?Tags, List<MenuSide>? Sides);
    public record MenuSide (string Name, double ExtraCost);

   
}
