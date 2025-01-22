using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Interactivity;
using Recipe_new.Util;

namespace Recipe_new;

public partial class AddRecipeWindow : Window
{
    private MainWindow mainWindow;
    private ObservableCollection<Ingredient> ingredients;
    public AddRecipeWindow(MainWindow mainWindow)
    {
        this.mainWindow = mainWindow;
        this.ingredients = new ObservableCollection<Ingredient>();
        InitializeComponent();
        
        IngredientList.ItemsSource = ingredients;
        IngredientList.DisplayMemberBinding = new Binding("ingredient_name");
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        MainWindow.globalManager.GetRecipeManager().AddRecipe(new Recipe(RecipeName.Text, ingredients));
    }

    private void AddIngredient_OnClick(object? sender, RoutedEventArgs e)
    {
        ingredients.Add(new Ingredient(IngredientName.Text));
    }
}