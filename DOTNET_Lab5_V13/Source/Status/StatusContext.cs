namespace DOTNET_Lab5_V13.Source.Status
{
    class StatusContext
    {
        private TaskStatusAbstraction _status = null;

        public StatusContext(TaskStatusAbstraction status)
        {
            this._status = status;
        }

        public void TransitionTo(TaskStatusAbstraction status)
        {
            this._status = status;
            this._status.SetContext(this);
        }

        public TaskStatusAbstraction GetStatus()
        {
            return this._status;
        }

        public override string ToString()
        {
            return this._status.ToString();
        }
    }
}
