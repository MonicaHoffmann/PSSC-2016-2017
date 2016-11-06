using Models.Generics;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Professor
{
    //clasa subjects are scopul de al lasa pe profesor sa faca, pt o materie de-a sa, urmatoarele
    //lucruri: sa adauge note la exam, nota la activitatea pe parcurs si prezenta, si sa seteze
    //proportia activitatii pe parcurs
    
    public class Subjects
    {
        private List<Subject.Subject> _subjects;
        public ReadOnlyCollection<Subject.Subject> AllSubjects { get { return _subjects.AsReadOnly(); } }

        public Subjects(List<Subject.Subject> subjects)
        {
            _subjects = subjects;
        }

        public void AddExamGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            _subjects.Find(d => d.SubjectInfo.Name == subjectName)
                .GetSituationForStudent(regNumber)
                .AddExamGrade(grade);
        }

        public void AddActivityGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            _subjects.Find(d => d.SubjectInfo.Name == subjectName)
                .GetSituationForStudent(regNumber)
                .AddActivityGrade(grade);
        }

        public void AddAttendance(PlainText subjectName, RegistrationNumber regNumber, Attendance attendance)
        {
            _subjects.Find(d => d.SubjectInfo.Name == subjectName)
                .GetSituationForStudent(regNumber)
                .AddAttendance(attendance);
        }

        public void SetActivityProportion(PlainText subjectName, Proportion proportion)
        {
            _subjects.Find(d => d.SubjectInfo.Name == subjectName).SubjectInfo.SetActivityProportion(proportion);
        }
    }
}
