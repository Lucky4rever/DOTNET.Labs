using DOTNET_Lab5_V13.Source.Status;
using System.Text;

namespace DOTNET_Lab5_V13.Source
{
    class Task
    {
        public readonly string Description;
        private string _solution;
        private StatusContext _status;

        public Task(string description)
        {
            StatusFactory factory = new StatusFactory();

            this.Description = description;
            this._status = new StatusContext(factory.Issued());
        }

        public Task Copy()
        {
            Task clone = new Task(this.Description);

            clone.SetSolution(this._solution);
            clone.SetStatus(this._status.GetStatus());

            return clone;
        }

        public void SetSolution(string solution)
        {
            this._solution = solution;
            this._status.TransitionTo(new Completed());
        }

        public string GetSolution()
        {
            return this._solution;
        }

        public void SetStatus(TaskStatusAbstraction status)
        {
            this._status.TransitionTo(status);
        }

        public TaskStatusAbstraction GetStatus()
        {
            return this._status.GetStatus();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{this.Description}");
            builder.AppendLine($"Solution: {this._solution ?? "none"}");
            builder.AppendLine($"Status: {this._status}");

            return builder.ToString();
        }
    }
}
