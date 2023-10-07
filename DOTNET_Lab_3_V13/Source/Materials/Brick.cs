namespace DOTNET_Lab3_V13.Source.Materials
{
    class Brick : Material
    {
        private BrickType Type { get; set; }

        public Brick(BrickType type, int count) : base(count)
        {
            this.Type = type;
        }

        public override string ToString()
        {
            return $"{this.Type} brick ({this.Count} pieces)";
        }
    }
}
