using DOTNET_Lab5_V13.Exceptions;
using DOTNET_Lab5_V13.Source.Interfaces;
using System;

namespace DOTNET_Lab5_V13.Source.Status
{
    class NeedToResubmit : TaskStatus
    {
        public override string ToString()
        {
            return "Need to resubmit";
        }

        public override void ChangeStatus(ITaskStatus status)
        {
            Type statusType = status.GetType();

            if (statusType == typeof(Submitted))
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
