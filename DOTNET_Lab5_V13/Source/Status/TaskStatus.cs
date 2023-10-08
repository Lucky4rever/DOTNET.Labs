using DOTNET_Lab5_V13.Source.Interfaces;

namespace DOTNET_Lab5_V13.Source.Status
{
    abstract class TaskStatus : ITaskStatus
    {
        protected IStatusContext _context;

        public void SetContext(IStatusContext context)
        {
            this._context = context;
        }

        public override string ToString()
        {
            return this._context.ToString();
        }
    }
}
