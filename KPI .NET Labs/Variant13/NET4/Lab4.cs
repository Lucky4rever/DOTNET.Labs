﻿using System;

namespace KPI.NET_Labs.Variant13.NET4
{
    class Lab4
    {
        private static Lab4 _instance;

        private Lab4() { }

        public static Lab4 GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Lab4();
            }

            return _instance;
        }

        public void Var13_Lab4()
        {
            Console.WriteLine("Variant 13\nVariant 4\n");

            RecipeFasade fasade = new RecipeFasade();

            // Create doctor and patients

            Doctor doctor = new Doctor("Snigur Pavlo", DoctorPosition.Therapist);

            Patient patient1 = new Patient("Andrey Semko");
            Patient patient2 = new Patient("Dmitry Manov");
            Patient patient3 = new Patient("Grisha Mishanov");

            // Create resipes

            RecipeBuilder builder = new RecipeBuilder();

            builder.SetDescription("Antibiotics");
            builder.SetDoctor(doctor);
            builder.SetPatient(patient1);
            builder.SetEndDate(new DateTime(2023, 9, 9));

            fasade.AddRecipe(builder.Build());

            builder = new RecipeBuilder();

            builder.SetDescription("Anti-inflammatory drug");
            builder.SetDoctor(doctor);
            builder.SetPatient(patient2);
            builder.SetEndDate(DateTime.Now.AddDays(14));

            fasade.AddRecipe(builder.Build());

            builder = new RecipeBuilder();

            builder.SetDescription("Vitamins");
            builder.SetDoctor(doctor);
            builder.SetPatient(patient3);
            builder.SetEndDate(DateTime.Now.AddDays(30));

            fasade.AddRecipe(builder.Build());

            // Check is any recipe deprecated

            fasade.CheckDate();

            // Show all recipes

            Console.WriteLine("\nShow all recipes\n");

            foreach (var recipe in fasade.GetRecipes())
            {
                Console.WriteLine(recipe);
            }

            // Increase recipe's end date and check it

            Console.WriteLine("Increase end date for 20 days\n");

            fasade.IncreaseEndDate(fasade.GetPatientRecipe(patient2), 20);

            Console.WriteLine(fasade.GetPatientRecipe(patient2));

            Console.WriteLine();
        }
    }
}
