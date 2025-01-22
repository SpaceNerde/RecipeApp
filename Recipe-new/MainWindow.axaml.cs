using System.Linq;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Input;
using Avalonia.Interactivity;
using Recipe_new.Util;

namespace Recipe_new;

public partial class MainWindow : Window
{
    public static GlobalManager globalManager;
    
    public MainWindow()
    {
        globalManager = new GlobalManager();
        InitializeComponent();
        
        RecipeList.ItemsSource = globalManager.GetRecipeManager().GetRecipes();
        RecipeList.DisplayMemberBinding = new Binding("name");
    }


    private void AddRecipeButton_OnClick(object? sender, RoutedEventArgs e)
    {
        Window addRecipeWindow = new AddRecipeWindow(this);
        
        addRecipeWindow.Show();
    }

    private void RecipeList_OnDoubleTapped(object? sender, TappedEventArgs e)
    {
        Window recipeWindow = new RecipeWindow(RecipeList.SelectedItem as Recipe);
        
        recipeWindow.Show();
    }

    private void RemoveRecipeButton_OnClick(object? sender, RoutedEventArgs e)
    {
        globalManager.GetRecipeManager().RemoveRecipe(RecipeList.SelectedItem as Recipe);
    }
}