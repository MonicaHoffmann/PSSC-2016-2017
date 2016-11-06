using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics;
using System.Diagnostics.Contracts;
using Models.Subject;

namespace Models.Student
{
    //factory pt root-ul de agregare GradeReport

    public class GradeReportFactory
    {
        public GradeReport CreateGradeReport(ReadOnlyCollection<KeyValuePair<SubjectInformation, SubjectSituation>> gradeReport)
        {
            GradeReport _gradeReport = new GradeReport(gradeReport);
            return _gradeReport;
        }
        
        /*
        public Student CreateStudent(RegistrationNumber regNumber, PlainText name)
        {
            Contract.Requires<ArgumentNullException>(regNumber != null, "regNumber is null");
            Contract.Requires<ArgumentNullException>(name != null, "name is null");
            Student student = new Student(regNumber, name);
            return student;
        }
      */
    }
}
