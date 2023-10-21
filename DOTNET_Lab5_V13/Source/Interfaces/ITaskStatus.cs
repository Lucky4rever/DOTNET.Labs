namespace DOTNET_Lab5_V13.Source.Interfaces
{
    interface ITaskStatus
    {
        void SetContext(IStatusContext context);
        void ChangeStatus(ITaskStatus status);
        string ToString();
    }
}
