using DOTNET_Lab3_V13.Source.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DOTNET_Lab3_V13.Source
{
    class SuppliersList : ISuppliersList
    {
        private readonly List<ISupplier> _suppliers;

        public SuppliersList()
        {
            this._suppliers = new List<ISupplier>();
        }

        public void AddSupplier(ISupplier supplier)
        {
            this._suppliers.Add(supplier);
        }

        public (string, IList<ISupplierListItem>) FindBestItems(IMaterial material, int count)
        {
            if (count <= 0)
            {
                throw new ArgumentOutOfRangeException("Count must be greater than zero.");
            }

            List<ISupplierListItem> сhecklist = this._suppliers
                .SelectMany(supplier => supplier
                    .GetItemList()
                    .Where(item => item.Material == material)
                )
                .OrderBy(item => item.MaxCount)
                .ToList();

            int dialedCount = 0;
            List<ISupplierListItem> result = new List<ISupplierListItem>();

            while (dialedCount < count && сhecklist.Count > 0)
            {
                ISupplierListItem bestItem = сhecklist
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

        public ISupplier FindSupplier(IMaterial material, int count, decimal maxPrice)
        {
            if (count <= 0 || maxPrice <= 0)
            {
                throw new ArgumentOutOfRangeException("Values must be greater than zero.");
            }

            ISupplier perfectSupplier = this._suppliers.Find(
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
