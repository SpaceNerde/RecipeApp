using System.Collections.ObjectModel;

namespace Recipe_new.Util;

public class RecipeManager
{
    private ObservableCollection<Recipe> recipes { set; get; }

    public RecipeManager()
    {
        recipes = new ObservableCollection<Recipe>();
    }

    public void AddRecipe(Recipe recipe)
    {
        recipes.Add(recipe);
    }
    
    public void RemoveRecipe(Recipe recipe)
    {
        recipes.Remove(recipe);
    }
    
    public ObservableCollection<Recipe> GetRecipes()
    {
        return recipes;
    }
}