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
    private ObservableCollection<WorkStep> work_steps;
    
    public AddRecipeWindow(MainWindow mainWindow)
    {
        this.mainWindow = mainWindow;
        ingredients = new ObservableCollection<Ingredient>();
        work_steps = new ObservableCollection<WorkStep>();
        
        InitializeComponent();
        
        IngredientList.ItemsSource = ingredients;
        IngredientList.DisplayMemberBinding = new Binding("ingredient_name");
        
        WorkStepList.ItemsSource = work_steps;
        WorkStepList.DisplayMemberBinding = new Binding("work_step_name");
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        MainWindow.globalManager.GetRecipeManager().AddRecipe(new Recipe(RecipeName.Text, ingredients, work_steps, CatergoryName.Text));
    }

    private void AddIngredient_OnClick(object? sender, RoutedEventArgs e)
    {
        ingredients.Add(new Ingredient(IngredientName.Text));
    }

    private void AddWorkStep_OnClick(object? sender, RoutedEventArgs e)
    {
        work_steps.Add(new WorkStep(WorkStepName.Text));
    }
}