using DOTNET_Lab4_V13.Source.Interfaces;
using System;
using System.Text;

namespace DOTNET_Lab4_V13.Source
{
    class Recipe : IRecipe
    {
        public string Description { get; set; }
        public IDoctor Doctor { get; set; }
        public IPerson Patient { get; set; }
        public DateTime EndDate { get; set; }

        public void IncreaseEndDate(double days)
        {
            this.EndDate = this.EndDate.AddDays(days);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"Description: {this.Description}");
            builder.AppendLine($"Doctor: {this.Doctor.Name} ({this.Doctor.Position})");
            builder.AppendLine($"Patient: {this.Patient.Name}");
            builder.AppendLine($"End date: {this.EndDate:dd.MM.yyyy}");

            return builder.ToString();
        }
    }
}
