using System;
using System.Collections.Generic;
using System.Text;

namespace BShopSolution.Utilities.Exceptions
{
    public class BShopException : Exception
    {
        public BShopException()
        { 
        }
        public BShopException(string message)
            : base(message)
        {
        }

        public BShopException(string message,Exception inner)
            : base(message, inner)
        { }
    }
}
