using DOTNET_Lab5_V13.Source.Interfaces;

namespace DOTNET_Lab5_V13.Source
{
    abstract class Person
    {
        public string _name;

        public Person(string name)
        {
            this._name = name;
        }

        public string GetName()
        {
            return this._name;
        }

        public override string ToString()
        {
            return this._name;
        }
    }
}
