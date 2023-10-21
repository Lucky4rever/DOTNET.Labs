using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTNET_Lab4_V13.Exceptions
{
    class EmptyListException : Exception
    {
        public EmptyListException() : base("List is empty")
        {

        }
    }
}
