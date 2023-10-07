namespace DOTNET_Lab5_V13.Source.Status
{
    abstract class TaskStatusAbstraction
    {
        protected StatusContext _context;

        public void SetContext(StatusContext context)
        {
            this._context = context;
        }

        public override string ToString()
        {
            return this._context.ToString();
        }
    }
}
