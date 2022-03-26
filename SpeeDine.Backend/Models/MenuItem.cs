using System;
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

    public static class MenuTagExt
    {
        public static string AsDisplayString(this MenuTag tag)
        {
            switch (tag)
            {
                case MenuTag.Vegetarian: return "Vegetarian";
                case MenuTag.Vegan: return "Vegan";
                case MenuTag.GlutenFree: return "Gluten Free";
                case MenuTag.PeanutFree: return "Peanut Free";
                case MenuTag.KetoFriendly: return "Keto Friendly";

                default: throw new ArgumentOutOfRangeException("MenuTag");
            }
        }
    }

    public record MenuItem (int Id, string Name, string Description, double Price, string ImgLink, List<MenuCategory> Categories, List<MenuTag> ?Tags, List<MenuSide>? Sides);
    public record MenuSide (string Name, double ExtraCost);

   
}
