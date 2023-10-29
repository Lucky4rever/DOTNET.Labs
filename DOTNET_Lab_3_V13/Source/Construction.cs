using DOTNET_Lab3_V13.Source.Interfaces;
using System.Collections.Generic;

namespace DOTNET_Lab3_V13.Source
{
    class Construction : IConstruction
    {
        private readonly List<IRequiredItem> _requiredItems;
        private readonly List<ISupplierListItem> _procurementItems;

        public Construction()
        {
            this._requiredItems = new List<IRequiredItem>();
            this._procurementItems = new List<ISupplierListItem>();
        }

        public void AddNewRequiredItem(IRequiredItem item)
        {
            this._requiredItems.Add(item);
        }

        public void AddProcurementItem(ISupplierListItem item)
        {
            this._procurementItems.Add(item);
        }

        public IList<IRequiredItem> GetRequiredItems()
        {
            return this._requiredItems;
        }

        public IList<ISupplierListItem> GetProcurementItems()
        {
            return this._procurementItems;
        }
    }
}
