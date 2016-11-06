using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Deanship
{
    //factory pt root-ul de agregare StudyYear

    public class StudyYearFactory
    {
        public StudyYear CreateStudyYear(List<Subject.Subject> studyYear)
        {
            StudyYear _studyYear = new StudyYear(studyYear);
            return _studyYear;
        }
    }
}
