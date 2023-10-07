using DOTNET_Lab3_V13.Source.Materials;

namespace DOTNET_Lab3_V13.Source
{
    class RequiredItem
    {
        public Material Material { get; set; }
        public int MaxCount { get; set; }

        public RequiredItem(Material material, int count)
        {
            this.Material = material;
            this.MaxCount = count;
        }
    }
}
