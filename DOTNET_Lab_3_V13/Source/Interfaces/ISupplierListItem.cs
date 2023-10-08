namespace DOTNET_Lab3_V13.Source.Interfaces
{
    interface ISupplierListItem : IRequiredItem
    {
        decimal PriceForSet { get; set; }

        string ToString();
    }
}
