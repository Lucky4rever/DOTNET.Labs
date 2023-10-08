using DOTNET_Lab5_V13.Source.Interfaces;

namespace DOTNET_Lab5_V13.Source
{
    abstract class Person : IPerson
    {
        public string Name { get; }

        public Person(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
