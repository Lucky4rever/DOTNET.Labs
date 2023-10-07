using KPI.NET_Labs.Variant13.NET3.Materials;

namespace KPI.NET_Labs.Variant13.NET3
{
    class SupplierListItem : RequiredItem
    {
        public decimal PriceForSet { get; set; }

        public SupplierListItem(Material material, int count, decimal price) 
            : base(material, count)
        {
            this.PriceForSet = price;
        }

        public override string ToString()
        {
            return $"{this.Material} for {this.PriceForSet} for 1 set and with max count {this.MaxCount}";
        }
    }
}
