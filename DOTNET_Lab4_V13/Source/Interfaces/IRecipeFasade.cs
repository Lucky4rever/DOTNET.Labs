using System.Collections.Generic;

namespace DOTNET_Lab4_V13.Source.Interfaces
{
    interface IRecipeFasade
    {
        void AddRecipe(IRecipe recipe);
        void RemoveRecipe(IRecipe recipe);
        IList<IRecipe> GetRecipes();
        void CheckDate();
        void IncreaseEndDate(IRecipe recipe, double days);
        IRecipe GetPatientRecipe(IPerson patient);
    }
}
