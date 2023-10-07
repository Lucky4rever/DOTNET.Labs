namespace DOTNET_Lab3_V13.Source.Materials
{
    class Concrete : Material
    {
        public Concrete(int count) : base(count) { }

        public override string ToString()
        {
            return $"Concrete ({this.Count} bags)";
        }
    }
}
