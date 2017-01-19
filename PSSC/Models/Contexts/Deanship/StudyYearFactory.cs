using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Contexts.Deanship
{
    class StudyYearFactory
    {
        public StudyYear CreateStudyYear(Guid id, HashSet<DefinedSubject> definedSubjects)
        {
            StudyYear _studyYear = new StudyYear(id, definedSubjects);
            return _studyYear;
        }
        public StudyYear CreateStudyYear(HashSet<DefinedSubject> definedSubjects)
        {
            StudyYear _studyYear = new StudyYear(definedSubjects);
            return _studyYear;
        }
    }
}
