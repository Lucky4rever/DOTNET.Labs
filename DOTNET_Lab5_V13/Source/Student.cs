using System.Text;

namespace DOTNET_Lab5_V13.Source
{
    class Student : Person
    {
        private int _asscessment { get; set; }
        private Task _task { get; set; }

        public Student(string name) : base(name)
        {
            this._asscessment = 0;
        }

        public Task GetTask()
        {
            return this._task;
        }

        public void SetTask(Task task)
        {
            this._task = task.Copy();
        }

        public void SetTaskSolution(string solution)
        {
            this._task.SetSolution(solution);
        }

        public int GetAssessment()
        {
            return this._asscessment;
        }

        public void SetAssessment(int assessment)
        {
            this._asscessment += assessment;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"Student: {this.Name}");
            builder.Append($"Task: {this._task.ToString() ?? "none"}");

            return builder.ToString();
        }
    }
}
