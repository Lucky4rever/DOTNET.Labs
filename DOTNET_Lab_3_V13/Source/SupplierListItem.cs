﻿using DOTNET_Lab3_V13.Source.Interfaces;

namespace DOTNET_Lab3_V13.Source
{
    class SupplierListItem : RequiredItem, ISupplierListItem
    {
        public decimal PriceForSet { get; set; }

        public SupplierListItem(IMaterial material, int count, decimal price) 
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
