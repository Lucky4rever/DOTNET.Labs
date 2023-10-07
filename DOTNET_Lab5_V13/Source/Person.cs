namespace DOTNET_Lab5_V13.Source
{
    abstract class Person
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
