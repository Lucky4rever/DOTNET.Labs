namespace DOTNET_Lab5_V13.Source.Status
{
    class StatusFactory
    {
        public TaskStatusAbstraction Issued()
        {
            return new Issued();
        }

        public TaskStatusAbstraction Completed()
        {
            return new Completed();
        }

        public TaskStatusAbstraction Incompleted()
        {
            return new Incompleted();
        }

        public TaskStatusAbstraction Checked()
        {
            return new Checked();
        }

        public TaskStatusAbstraction NeedToResubmit()
        {
            return new NeedToResubmit();
        }

        public TaskStatusAbstraction Submitted()
        {
            return new Submitted();
        }
    }
}
