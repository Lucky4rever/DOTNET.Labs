using DOTNET_Lab5_V13.Source.Interfaces;

namespace DOTNET_Lab5_V13.Source.Status
{
    class StatusFactory : IStatusFactory
    {
        public ITaskStatus Issued()
        {
            return new Issued();
        }

        public ITaskStatus Completed()
        {
            return new Completed();
        }

        public ITaskStatus Incompleted()
        {
            return new Incompleted();
        }

        public ITaskStatus Checked()
        {
            return new Checked();
        }

        public ITaskStatus NeedToResubmit()
        {
            return new NeedToResubmit();
        }

        public ITaskStatus Submitted()
        {
            return new Submitted();
        }
    }
}
