using DOTNET_Lab5_V13.Source.Interfaces;

namespace DOTNET_Lab5_V13.Source.Status
{
    class StatusContext : IStatusContext
    {
        private ITaskStatus _status = null;

        public StatusContext(ITaskStatus status)
        {
            this._status = status;
        }

        public void TransitionTo(ITaskStatus status)
        {
            this._status = status;
            this._status.SetContext(this);
        }

        public ITaskStatus GetStatus()
        {
            return this._status;
        }

        public override string ToString()
        {
            return this._status.ToString();
        }
    }
}
