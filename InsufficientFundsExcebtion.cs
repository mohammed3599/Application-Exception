using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Exception
{
        internal class InsufficientFundsException : Exception
        {
            public InsufficientFundsException()
            {
            }

            public override string ToString()
            {
                return $"Error, The balance eis less than amount";
            }


        }
    }
}
