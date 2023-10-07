using System.Collections.Generic;

namespace DOTNET_Labs.Variant13.NET3
{
    class Construction
    {
        private readonly List<RequiredItem> _requiredItems;
        private readonly List<SupplierListItem> _procurementItems;

        public Construction()
        {
            this._requiredItems = new List<RequiredItem>();
            this._procurementItems = new List<SupplierListItem>();
        }

        public void AddNewRequiredItem(RequiredItem item)
        {
            this._requiredItems.Add(item);
        }

        public void AddProcurementItem(SupplierListItem item)
        {
            this._procurementItems.Add(item);
        }

        public List<RequiredItem> GetRequiredItems()
        {
            return this._requiredItems;
        }

        public List<SupplierListItem> GetProcurementItems()
        {
            return this._procurementItems;
        }
    }
}
