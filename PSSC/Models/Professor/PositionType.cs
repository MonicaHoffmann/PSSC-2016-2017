using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Professor
{
    //pozitia pe care o poate ocupa un profesor

    public class PositionType
    {
        public enum Type
        {
            Asistent,
            Lector,
            Conferentiar,
            Profesor
        }
    }
}
