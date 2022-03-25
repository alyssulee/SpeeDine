using System.Collections.Generic;

namespace SpeeDine.Backend.Models
{
    public enum MenuCategory
    {
        Pinned,
        Popular,
        Dinner,
        Appetizer,
        Lunch,
        Dessert,
        Kids,
        Drinks
    }

    public enum MenuTag
    {
        Vegetarian,
        Vegan,
        GlutenFree,
        PeanutFree,
        KetoFriendly
    }

    public record MenuItem (int Id, string Name, string Description, double Price, string ImgLink, List<MenuCategory> Categories, List<MenuTag> ?Tags, List<MenuSide>? Sides);
    public record MenuSide (string Name, double ExtraCost);

   
}
