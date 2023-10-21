using DOTNET_Lab5_V13.Exceptions;
using DOTNET_Lab5_V13.Source.Interfaces;
using System;

namespace DOTNET_Lab5_V13.Source.Status
{
    class Checked : TaskStatus
    {
        public override string ToString()
        {
            return "Checked";
        }

        public override void ChangeStatus(ITaskStatus status)
        {
            throw new WrongStatusException();
        }
    }
}
