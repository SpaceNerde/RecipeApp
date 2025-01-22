using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Recipe_new.Util;

public enum Kategories
{
    Vegan,
    NonVegan,
    Vegaterien
}

public class Recipe
{
    public string name { get; set; }
    public ObservableCollection<Ingredient> ingredients;
    public ObservableCollection<WorkStep> WorkSteps;
    public string kategorie { get; set; }

    public Recipe(string name, ObservableCollection<Ingredient> ingredients, ObservableCollection<WorkStep> work_steps, string kategorie)
    {
        this.name = name;
        this.ingredients = ingredients;
        this.WorkSteps = work_steps;
        this.kategorie = kategorie;
    }
}