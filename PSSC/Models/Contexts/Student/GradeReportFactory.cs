using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics.ValueObjects;

namespace Models.Contexts.Student
{
    class GradeReportFactory
    {
        public GradeReport CreateGradeReport(RegistrationNumber id, HashSet<EnrolledSubject> gradeReport)
        {
            GradeReport _gradeReport = new GradeReport(id, gradeReport);
            return _gradeReport;
        }
    }
}
