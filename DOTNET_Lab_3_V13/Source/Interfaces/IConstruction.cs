using System.Collections.Generic;

namespace DOTNET_Lab3_V13.Source.Interfaces
{
    interface IConstruction
    {
        void AddNewRequiredItem(IRequiredItem item);
        void AddProcurementItem(ISupplierListItem item);
        IList<IRequiredItem> GetRequiredItems();
        IList<ISupplierListItem> GetProcurementItems();
    }
}
