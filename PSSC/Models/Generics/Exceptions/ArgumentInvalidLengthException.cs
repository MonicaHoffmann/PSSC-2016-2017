using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.Exceptions
{
    //exceptie pt dimensiunea invalida

    public class ArgumentInvalidLengthException : ArgumentException
    {
        public ArgumentInvalidLengthException(string message)
            : base(message)
        {

        }
    }
}
