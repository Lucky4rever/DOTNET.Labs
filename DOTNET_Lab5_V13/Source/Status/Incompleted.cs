using DOTNET_Lab5_V13.Exceptions;
using DOTNET_Lab5_V13.Source.Interfaces;

namespace DOTNET_Lab5_V13.Source.Status
{
    class Incompleted : TaskStatus
    {
        public override string ToString()
        {
            return "Incompleted";
        }

        public override void ChangeStatus(ITaskStatus status)
        {
            throw new WrongStatusException();
        }
    }
}
