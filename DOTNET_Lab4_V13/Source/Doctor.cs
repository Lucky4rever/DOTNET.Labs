namespace DOTNET_Lab4_V13.Source
{
    class Doctor
    {
        public string Name { get; private set; }
        public DoctorPosition Position { get; private set; }

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
