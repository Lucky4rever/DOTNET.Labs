using DOTNET_Lab4_V13.Exceptions;
using DOTNET_Lab4_V13.Source.Interfaces;
using System.Collections.Generic;

namespace DOTNET_Lab4_V13.Source
{
    class RecipeStorage : IRecipeStorage
    {
        private readonly List<IRecipe> _recipes;

        public RecipeStorage()
        {
            this._recipes = new List<IRecipe>();
        }

        public void Add(IRecipe recipe)
        {
            this._recipes.Add(recipe);
        }

        public void Remove(IRecipe recipe)
        {
            this._recipes.Remove(recipe);
        }

        public IList<IRecipe> GetAllRecipes()
        {
            return this._recipes;
        }

        public void IncreaseEndDate(IRecipe recipe, double days)
        {
            if (this._recipes.Count == 0)
            {
                throw new EmptyListException();
            }

            this._recipes.Find(_recipe => _recipe == recipe)
                .IncreaseEndDate(days);
        }
    }
}
