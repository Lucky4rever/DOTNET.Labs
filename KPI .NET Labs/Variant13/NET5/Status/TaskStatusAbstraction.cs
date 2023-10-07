namespace DOTNET_Labs.Variant13.NET5.Status
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
