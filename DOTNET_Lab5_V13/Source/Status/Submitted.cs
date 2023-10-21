using DOTNET_Lab5_V13.Exceptions;
using DOTNET_Lab5_V13.Source.Interfaces;
using System;

namespace DOTNET_Lab5_V13.Source.Status
{
    class Submitted : TaskStatus
    {
        public override string ToString()
        {
            return "Submitted";
        }

        public override void ChangeStatus(ITaskStatus status)
        {
            Type statusType = status.GetType();

            if (statusType == typeof(Checked) || statusType == typeof(Incompleted) || statusType == typeof(NeedToResubmit))
            {
                this._context.TransitionTo(status);
            }
            else
            {
                throw new WrongStatusException(nameof(status));
            }
        }
    }
}
