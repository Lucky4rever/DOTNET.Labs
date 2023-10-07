using KPI.NET_Labs.Variant13.NET3.Materials;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KPI.NET_Labs.Variant13.NET3
{
    class SuppliersList
    {
        private readonly List<Supplier> _suppliers;

        public SuppliersList()
        {
            this._suppliers = new List<Supplier>();
        }

        public void AddSupplier(Supplier supplier)
        {
            this._suppliers.Add(supplier);
        }

        public (string, List<SupplierListItem>) FindBestItems(Material material, int count)
        {
            List<SupplierListItem> сhecklist = _suppliers
                .SelectMany(supplier => supplier
                    .GetItemList()
                    .Where(item => item.Material == material)
                )
                .OrderBy(item => item.MaxCount)
                .ToList();

            int dialedCount = 0;
            List<SupplierListItem> result = new List<SupplierListItem>();

            while (dialedCount < count && сhecklist.Count > 0)
            {
                SupplierListItem bestItem = сhecklist
                    .First(x => x.PriceForSet == сhecklist.Min(item => item.PriceForSet));

                result.Add(bestItem);
                dialedCount += bestItem.MaxCount;

                сhecklist.Remove(bestItem);
            }

            if (dialedCount < count)
            {
                return ("The resource requirement is not fulfilled", result);
            }

            return ("Complete", result);
        }

        public Supplier FindSupplier(Material material, int count, decimal maxPrice)
        {
            Supplier perfectSupplier = _suppliers.Find(
                    supplier => supplier.GetItemList().FindAll(
                            item => item.Material == material
                            && item.MaxCount >= count
                            && item.PriceForSet <= maxPrice
                        ) != null
                );

            return perfectSupplier;
        }
    }
}
