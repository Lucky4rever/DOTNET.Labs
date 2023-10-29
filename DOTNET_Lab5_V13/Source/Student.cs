using DOTNET_Lab5_V13.Source.Interfaces;
using System.Text;

namespace DOTNET_Lab5_V13.Source
{
    class Student : Person, IStudent
    {
        private int _asscessment;
        private Task _task;

        public Student(string name) : base(name)
        {
            this._asscessment = 0;
        }

        public ITask GetTask()
        {
            return this._task;
        }

        public void SetTask(ITask task)
        {
            this._task = (Task)task.Copy();
        }

        public void SetTaskSolution(string solution)
        {
            this._task.SetSolution(solution);
        }

        public int GetAssessment()
        {
            return this._asscessment;
        }

        public void IncreaseAssessment(int assessment)
        {
            this._asscessment += assessment;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"Student: {this.GetName()}");
            builder.AppendLine($"Assessment: {this._asscessment}");
            builder.Append($"Task: {this._task.ToString() ?? "none"}");

            return builder.ToString();
        }
    }
}
