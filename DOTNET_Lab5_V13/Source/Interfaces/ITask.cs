namespace DOTNET_Lab5_V13.Source.Interfaces
{
    interface ITask
    {
        ITask Copy();
        void SetSolution(string solution);
        string GetSolution();
        void SetStatus(ITaskStatus status);
        ITaskStatus GetStatus();
        string ToString();
    }
}
