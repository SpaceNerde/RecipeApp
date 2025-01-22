using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Interactivity;
using Recipe_new.Util;

namespace Recipe_new;

public partial class RecipeWindow : Window
{
    public RecipeWindow(Recipe recipe)
    {
        InitializeComponent();

        RecipeNameLabel.Content = recipe.name;
        IngredientListBox.ItemsSource = recipe.ingredients;
        IngredientListBox.DisplayMemberBinding = new Binding("ingredient_name");
    }
}