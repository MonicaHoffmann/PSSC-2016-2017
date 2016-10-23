using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum YearOfStudy
    {
        I,
        II,
        III,
        IV
    }
    public class Student
    {
        private string studentName;
        private YearOfStudy yearOfStudy;

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public YearOfStudy YearOfStudy
        {
            get { return yearOfStudy; }
            set { yearOfStudy = value; }
        }
    }
}
