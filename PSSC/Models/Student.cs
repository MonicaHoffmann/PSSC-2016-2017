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
        private string name;
        private YearOfStudy yearOfStudy;
        private Discipline[] disciplines = new Discipline[100];

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public YearOfStudy YearOfStudy
        {
            get { return yearOfStudy; }
            set { yearOfStudy = value; }
        }
        public Discipline[] Disciplines
        {
            get { return disciplines; }
            set { disciplines = value; }
        }

        public Student(string name, YearOfStudy yearOfStudy, Discipline[] disciplines)
        {
            this.name = name;
            this.yearOfStudy = yearOfStudy;
            this.disciplines = disciplines;
        }
    }
}
