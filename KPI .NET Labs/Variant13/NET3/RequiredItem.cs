using KPI.NET_Labs.Variant13.NET3.Materials;

namespace KPI.NET_Labs.Variant13.NET3
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
