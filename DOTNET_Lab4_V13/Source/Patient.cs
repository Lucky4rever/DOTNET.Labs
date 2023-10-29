using DOTNET_Lab4_V13.Source.Interfaces;

namespace DOTNET_Lab4_V13.Source
{
    class Patient : IPerson
    {
        public string Name { get; }

        public Patient(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
