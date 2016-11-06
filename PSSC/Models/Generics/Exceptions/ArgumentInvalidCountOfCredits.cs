using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.Exceptions
{
    //exceptie pt nr invalid de credite

    public class ArgumentInvalidCountOfCredits : ArgumentException
    {
        public ArgumentInvalidCountOfCredits (string message)
            : base(message)
        {

        }
    }
}
