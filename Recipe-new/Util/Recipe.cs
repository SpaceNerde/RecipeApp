using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Recipe_new.Util;

public class Recipe
{
    public string name { get; set; }
    public ObservableCollection<Ingredient> ingredients;

    public Recipe(string name, ObservableCollection<Ingredient> ingredients)
    {
        this.name = name;
        this.ingredients = ingredients;
    }
}