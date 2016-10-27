using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class GradeOngoingActivity
    {
        private int id;
        private Int16 grade;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Int16 Grade
        {
            get { return grade; }
            set { grade = value; }
        }
    }
}
