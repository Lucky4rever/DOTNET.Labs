using System.Collections.Generic;

namespace DOTNET_Lab3_V13.Source.Interfaces
{
    interface ISupplier
    {
        void SetItemList(List<ISupplierListItem> list);
        void AddItemToList(ISupplierListItem item);
        List<ISupplierListItem> GetItemList();
        string ToString();
    }
}
