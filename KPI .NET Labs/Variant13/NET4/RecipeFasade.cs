using System;
using System.Collections.Generic;

namespace DOTNET_Labs.Variant13.NET4
{
    class RecipeFasade
    {
        private RecipeStorage _recipes = new RecipeStorage();

        public void AddRecipe(Recipe recipe)
        {
            this._recipes.Add(recipe);
        }

        public void RemoveRecipe(Recipe recipe)
        {
            this._recipes.Remove(recipe);
        }

        public List<Recipe> GetRecipes()
        {
            return this._recipes.Get();
        }

        public void CheckDate()
        {
            List<Recipe> recipesCopy = new List<Recipe>(this._recipes.Get());

            recipesCopy.ForEach(recipe =>
            {
                if (recipe.EndDate <= DateTime.Now.Date)
                {
                    this.RemoveRecipe(recipe);
                }
            });
        }

        public void IncreaseEndDate(Recipe recipe, double days)
        {
            this.GetRecipes()
                .Find(_recipe => _recipe == recipe)
                .IncreaseEndDate(days);
        }

        public Recipe GetPatientRecipe(Patient patient)
        {
            return this.GetRecipes().Find(recipe => recipe.Patient == patient);
        }
    }
}
