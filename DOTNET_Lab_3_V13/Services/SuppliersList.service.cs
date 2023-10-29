using DOTNET_Lab3_V13.Exceptions;
using DOTNET_Lab3_V13.Source.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DOTNET_Lab3_V13.Services
{
    class SuppliersListService
    {
        public List<ISupplierListItem> FindBestItems(List<ISupplier> suppliers, IMaterial material, int count)
        {
            if (count <= 0)
            {
                throw new IntegralNumberException();
            }

            List<ISupplierListItem> сhecklist = suppliers
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
                throw new NotFullifiedException();
            }

            return result;
        }

        public ISupplier FindSupplier(List<ISupplier> suppliers, ISupplierListItem supplierListItem)
        {
            if (supplierListItem.MaxCount<= 0 || supplierListItem.PriceForSet <= 0)
            {
                throw new NotFullifiedException();
            }

            ISupplier perfectSupplier = suppliers.Find(
                    supplier => supplier
                        .GetItemList()
                        .FindAll(
                            item => item.Material == supplierListItem.Material
                            && item.MaxCount >= supplierListItem.MaxCount
                            && item.PriceForSet <= supplierListItem.PriceForSet
                        ) != null
                );

            return perfectSupplier;
        }
        public ISupplier FindSupplier(List<ISupplier> suppliers, IMaterial material, int count, decimal maxPrice)
        {
            if (count <= 0 || maxPrice <= 0)
            {
                throw new ArgumentOutOfRangeException("Values must be greater than zero.");
            }

            ISupplier perfectSupplier = suppliers.Find(
                    supplier => supplier
                        .GetItemList()
                        .FindAll(
                            item => item.Material == material
                            && item.MaxCount >= count
                            && item.PriceForSet <= maxPrice
                        ) != null
                );

            return perfectSupplier;
        }
    }
}
