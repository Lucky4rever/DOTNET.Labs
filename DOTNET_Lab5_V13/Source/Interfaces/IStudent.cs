namespace DOTNET_Lab5_V13.Source.Interfaces
{
    interface IStudent
    {
        ITask GetTask();
        void SetTask(ITask task);
        void SetTaskSolution(string solution);
        int GetAssessment();
        void IncreaseAssessment(int assessment);
    }
}
