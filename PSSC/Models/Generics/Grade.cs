using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    //valoarea unei note

    //value object
    public class Grade
    {
        private decimal _value;
        public decimal Value { get { return _value; } }

        public Grade(decimal value)
        {
            _value = value;
        }
    }
}
