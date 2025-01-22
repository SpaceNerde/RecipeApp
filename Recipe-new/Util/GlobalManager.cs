namespace Recipe_new.Util;

public class GlobalManager
{
    private static RecipeManager recipeManager;

    public GlobalManager()
    {
        recipeManager = new RecipeManager();
    }

    public RecipeManager GetRecipeManager()
    {
        return recipeManager;
    }
}