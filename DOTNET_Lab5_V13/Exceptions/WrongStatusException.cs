using System;

namespace DOTNET_Lab5_V13.Exceptions
{
    class WrongStatusException : Exception
    {
        public WrongStatusException() : base("Unable to change status")
        {
        }

        public WrongStatusException(string status) : base($"Unable to change status to \"{status}\"")
        {
        }
    }
}
