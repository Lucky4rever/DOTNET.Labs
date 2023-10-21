using DOTNET_Lab5_V13.Source.Interfaces;
using DOTNET_Lab5_V13.Source.Status;
using System.Text;

namespace DOTNET_Lab5_V13.Source
{
    class Task : ITask
    {
        private readonly string _description;
        private readonly StatusContext _status;
        private string _solution;

        public Task(string description)
        {
            StatusFactory factory = new StatusFactory();

            this._description = description;
            this._status = new StatusContext(new Issued());
        }

        public ITask Copy()
        {
            Task clone = new Task(this._description);

            clone.SetSolution(this._solution);

            return clone;
        }

        public void SetSolution(string solution)
        {
            this._solution = solution;
            this._status.GetStatus();
        }

        public string GetDescription()
        {
            return this._description;
        }

        public string GetSolution()
        {
            return this._solution;
        }

        public void SetStatus(ITaskStatus status)
        {
            this._status.GetStatus().ChangeStatus(status);
        }

        public ITaskStatus GetStatus()
        {
            return this._status.GetStatus();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{this._description}");
            builder.AppendLine($"Solution: {this._solution ?? "none"}");
            builder.AppendLine($"Status: {this._status}");

            return builder.ToString();
        }
    }
}
