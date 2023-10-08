namespace DOTNET_Lab5_V13.Source.Interfaces
{
    interface IStatusContext
    {
        void TransitionTo(ITaskStatus status);
        ITaskStatus GetStatus();
        string ToString();
    }
}
