using DOTNET_Lab3_V13.Source.Interfaces;
using System.Collections.Generic;

namespace DOTNET_Lab3_V13.Source
{
    class Supplier : ISupplier
    {
        private readonly string Name;
        private List<ISupplierListItem> _itemList;

        public Supplier(string name)
        {
            this.Name = name;
            this._itemList = new List<ISupplierListItem>();
        }

        public void SetItemList(List<ISupplierListItem> list)
        {
            this._itemList = list;
        }

        public void AddItemToList(ISupplierListItem item)
        {
            this._itemList.Add(item);
        }

        public List<ISupplierListItem> GetItemList()
        {
            return this._itemList;
        }

        public override string ToString()
        {
            return $"Supplier \"{this.Name}\"";
        }
    }
}
