using System;

namespace DOTNET_Lab3_V13.Exceptions
{
    class IntegralNumberException : Exception
    {
        public IntegralNumberException() : base("Count must be greater than zero.")
        {

        }
    }
}
