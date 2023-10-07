using System.Collections.Generic;

namespace DOTNET_Lab3_V13.Source
{
    class Supplier
    {
        private readonly string Name;
        private List<SupplierListItem> _itemList;

        public Supplier(string name)
        {
            this.Name = name;
            this._itemList = new List<SupplierListItem>();
        }

        public void SetItemList(List<SupplierListItem> list)
        {
            this._itemList = list;
        }

        public void AddItemToList(SupplierListItem item)
        {
            this._itemList.Add(item);
        }

        public List<SupplierListItem> GetItemList()
        {
            return this._itemList;
        }

        public override string ToString()
        {
            return $"Supplier \"{this.Name}\"";
        }
    }
}
