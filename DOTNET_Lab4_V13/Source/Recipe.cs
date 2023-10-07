using System;
using System.Text;

namespace DOTNET_Lab4_V13.Source
{
    class Recipe
    {
        public string Description { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
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
