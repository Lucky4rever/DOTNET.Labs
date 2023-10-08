using DOTNET_Lab3_V13.Source.Interfaces;

namespace DOTNET_Lab3_V13.Source
{
    class RequiredItem : IRequiredItem
    {
        public IMaterial Material { get; set; }
        public int MaxCount { get; set; }

        public RequiredItem(IMaterial material, int count)
        {
            this.Material = material;
            this.MaxCount = count;
        }
    }
}
