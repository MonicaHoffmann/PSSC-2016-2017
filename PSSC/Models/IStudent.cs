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
    public class IStudent
    {
        protected string studentName;
        protected YearOfStudy yearOfStudy;
        public string getStudentName() { return studentName; }
        public YearOfStudy getYearOfStudy() { return yearOfStudy; }
        public void setStudentName(string studentName) { this.studentName = studentName; }
        public void setYearOfStud(YearOfStudy yearOfStudy) { this.yearOfStudy = yearOfStudy; }
        public IStudent(string studentName, YearOfStudy yearOfStudy)
        {
            this.studentName = studentName;
            this.yearOfStudy = yearOfStudy;
        }
        public void receiveGradesFromProfessors();
        public void giveProjectsToProfessors(); 
    }
}
