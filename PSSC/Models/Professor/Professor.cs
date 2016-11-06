using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Professor
{
    //clasa profesor poate construi un profesor

    //entity
    public class Professor
    {
        public PlainText Name { get; internal set; }
        public PositionType PositionType { get; internal set; }

        public Professor(PlainText name, PositionType positionType)
        {
            PositionType = positionType;
            Name = name;
        }
    }
}
