using DOTNET_Lab4_V13.Exceptions;
using DOTNET_Lab4_V13.Source.Interfaces;
using System;
using System.Collections.Generic;

namespace DOTNET_Lab4_V13.Source
{
    class RecipeFasade : IRecipeFasade
    {
        private readonly IRecipeStorage _recipeStorage;

        public RecipeFasade()
        {
            this._recipeStorage = new RecipeStorage();
        }

        public void AddRecipe(IRecipe recipe)
        {
            this._recipeStorage.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            this._recipeStorage.Remove(recipe);
        }

        public IList<IRecipe> GetRecipes()
        {
            return this._recipeStorage.GetAllRecipes();
        }

        public void CheckDate()
        {
            List<IRecipe> recipesCopy = new List<IRecipe>(this.GetRecipes());

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
            this._recipeStorage.IncreaseEndDate(recipe, days);
        }

        public IRecipe GetPatientRecipe(IPerson patient)
        {
            List<IRecipe> recipes = (List<IRecipe>)this.GetRecipes();

            return recipes.Find(recipe => recipe.Patient == patient);
        }
    }
}
