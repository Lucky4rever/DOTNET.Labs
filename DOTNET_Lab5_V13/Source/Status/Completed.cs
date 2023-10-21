using DOTNET_Lab5_V13.Exceptions;
using DOTNET_Lab5_V13.Source.Interfaces;
using System;

namespace DOTNET_Lab5_V13.Source.Status
{
    class Completed : TaskStatus
    {
        public override string ToString()
        {
            return "Completed";
        }

        public override void ChangeStatus(ITaskStatus status)
        {
            Type statusType = status.GetType();

            if (statusType == typeof(Checked))
            {
                this._context.TransitionTo(status);
            }
            else
            {
                throw new WrongStatusException(status.ToString());
            }
        }
    }
}
