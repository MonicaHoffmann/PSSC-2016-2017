using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum SubjectYear 
    {
        I,
        II,
        III,
        IV
    }
    public class ISubject
    {
        protected string subjectName;
        protected SubjectYear subjectYear;
        public string getSubjectName() { return subjectName; }
        public SubjectYear getSubjectYear() { return subjectYear; }
        public void setSubjectName(string subjectName) { this.subjectName = subjectName; }
        public void setSubjectYear(SubjectYear subjectYear) { this.subjectYear = subjectYear; }
        public ISubject(string subjectName, SubjectYear subjectYear)
        {
            this.subjectName = subjectName;
            this.subjectYear = subjectYear;
        }
    }
}
