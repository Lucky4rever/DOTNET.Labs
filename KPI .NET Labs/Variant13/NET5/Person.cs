namespace DOTNET_Labs.Variant13.NET5
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
