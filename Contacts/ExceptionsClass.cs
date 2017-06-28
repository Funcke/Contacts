using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class StringTooShortException : Exception
    {
        public StringTooShortException() : base("The input string is too short, min. 2 chars")
        {
            ;
        }
    }

    class AgeOutOfRangeExceptrion : Exception
    {
        public AgeOutOfRangeExceptrion() : base("Watch out, you can't be younger than 0 or older than 150")
        {
            ;
        }
    }
}
