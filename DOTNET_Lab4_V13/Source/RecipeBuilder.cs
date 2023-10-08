using DOTNET_Lab4_V13.Source.Interfaces;
using System;

namespace DOTNET_Lab4_V13.Source
{
    class RecipeBuilder : IRecipeBuilder
    {
        private readonly Recipe _recipe;

        public RecipeBuilder()
        {
            this._recipe = new Recipe();
        }

        public void SetDescription(string description)
        {
            this._recipe.Description = description;
        }

        public void SetDoctor(IDoctor doctor)
        {
            this._recipe.Doctor = doctor;
        }

        public void SetPatient(IPerson patient)
        {
            this._recipe.Patient = patient;
        }

        public void SetEndDate(DateTime endDate)
        {
            this._recipe.EndDate = endDate.Date;
        }

        public Recipe Build()
        {
            return this._recipe;
        }
    }
}
