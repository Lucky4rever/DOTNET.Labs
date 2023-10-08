using DOTNET_Lab4_V13.Source.Interfaces;
using DOTNET_Lab4_V13.Source.Resourses;

namespace DOTNET_Lab4_V13.Source
{
    class Doctor : IDoctor
    {
        public string Name { get; }
        public DoctorPosition Position { get; }

        public Doctor(string name, DoctorPosition position)
        {
            this.Name = name;
            this.Position = position;
        }

        public override string ToString()
        {
            return $"{this.Position} {this.Name}";
        }
    }
}
