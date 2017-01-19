using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Contexts.Professor
{
    class SubjectsFactory
    {
        public Subjects CreateSubjects(HashSet<TeachingSubject> subjects)
        {
            Subjects _subjects = new Subjects(subjects);
            return _subjects;
        }
        public Subjects CreateSubjects(Guid id, HashSet<TeachingSubject> subjects)
        {
            Subjects _subjects = new Subjects(id, subjects);
            return _subjects;
        }
    }
}
