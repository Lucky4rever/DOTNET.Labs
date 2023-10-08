using System;

namespace DOTNET_Lab4_V13.Source.Interfaces
{
    interface IRecipe
    {
        string Description { get; set; }
        IDoctor Doctor { get; set; }
        IPerson Patient { get; set; }
        DateTime EndDate { get; set; }

        void IncreaseEndDate(double days);
        string ToString();
    }
}
