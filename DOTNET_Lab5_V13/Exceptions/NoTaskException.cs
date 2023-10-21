using System;

namespace DOTNET_Lab5_V13.Exceptions
{
    class NoTaskException : Exception
    {
        public NoTaskException() : base("This student has no task")
        {
        }
    }
}
