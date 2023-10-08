using System.Collections.Generic;

namespace DOTNET_Lab3_V13.Source.Interfaces
{
    interface ISuppliersList
    {
        void AddSupplier(ISupplier supplier);
        (string, IList<ISupplierListItem>) FindBestItems(IMaterial material, int count);
        ISupplier FindSupplier(IMaterial material, int count, decimal maxPrice);
    }
}
