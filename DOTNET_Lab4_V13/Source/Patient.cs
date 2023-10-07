namespace DOTNET_Lab4_V13.Source
{
    class Patient
    {
        public string Name { get; private set; }

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
