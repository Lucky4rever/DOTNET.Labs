namespace DOTNET_Lab3_V13.Source.Interfaces
{
    interface IRequiredItem
    {
        IMaterial Material { get; set; }
        int MaxCount { get; set; }
    }
}
