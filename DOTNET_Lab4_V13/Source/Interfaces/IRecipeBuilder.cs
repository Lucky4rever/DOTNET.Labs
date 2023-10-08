using System;

namespace DOTNET_Lab4_V13.Source.Interfaces
{
    interface IRecipeBuilder
    {
        void SetDescription(string description);
        void SetDoctor(IDoctor doctor);
        void SetPatient(IPerson patient);
        void SetEndDate(DateTime endDate);

        Recipe Build();
    }
}
