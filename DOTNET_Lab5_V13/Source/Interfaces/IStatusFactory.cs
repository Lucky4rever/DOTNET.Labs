namespace DOTNET_Lab5_V13.Source.Interfaces
{
    interface IStatusFactory
    {
        ITaskStatus Issued();
        ITaskStatus Completed();
        ITaskStatus Incompleted();
        ITaskStatus Checked();
        ITaskStatus NeedToResubmit();
        ITaskStatus Submitted();
    }
}
