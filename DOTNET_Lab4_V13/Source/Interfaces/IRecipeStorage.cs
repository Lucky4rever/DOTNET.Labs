using System.Collections.Generic;

namespace DOTNET_Lab4_V13.Source.Interfaces
{
    interface IRecipeStorage
    {
        void Add(IRecipe recipe);
        void Remove(IRecipe recipe);
        IList<IRecipe> GetAllRecipes();
    }
}
