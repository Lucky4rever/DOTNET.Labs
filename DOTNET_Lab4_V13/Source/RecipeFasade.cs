using DOTNET_Lab4_V13.Exceptions;
using DOTNET_Lab4_V13.Source.Interfaces;
using System;
using System.Collections.Generic;

namespace DOTNET_Lab4_V13.Source
{
    class RecipeFasade : IRecipeFasade
    {
        private readonly IRecipeStorage _recipes;

        public RecipeFasade()
        {
            this._recipes = new RecipeStorage();
        }

        public void AddRecipe(IRecipe recipe)
        {
            this._recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            this._recipes.Remove(recipe);
        }

        public IList<IRecipe> GetRecipes()
        {
            return this._recipes.GetAllRecipes();
        }

        public void CheckDate()
        {
            List<IRecipe> recipesCopy = new List<IRecipe>(GetRecipes());

            if (recipesCopy.Count == 0)
            {
                throw new EmptyListException();
            }

            recipesCopy.ForEach(recipe =>
            {
                if (recipe.EndDate <= DateTime.Now.Date)
                {
                    this.RemoveRecipe(recipe);
                }
            });
        }

        public void IncreaseEndDate(IRecipe recipe, double days)
        {
            List<IRecipe> recipes = (List<IRecipe>)GetRecipes();

            if (recipes.Count == 0)
            {
                throw new EmptyListException();
            }

            recipes.Find(_recipe => _recipe == recipe)
                .IncreaseEndDate(days);
        }

        public IRecipe GetPatientRecipe(IPerson patient)
        {
            List<IRecipe> recipes = (List<IRecipe>)GetRecipes();

            return recipes.Find(recipe => recipe.Patient == patient);
        }
    }
}
