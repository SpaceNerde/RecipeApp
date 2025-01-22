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
        CatergoryLabel.Content = recipe.kategorie;
        
        IngredientListBox.ItemsSource = recipe.ingredients;
        IngredientListBox.DisplayMemberBinding = new Binding("ingredient_name");
        
        WorkStepListBox.ItemsSource = recipe.WorkSteps;
        WorkStepListBox.DisplayMemberBinding = new Binding("work_step_name");
        
        // it is 11pm and my brain is not braining anymore pls send help
    }
}