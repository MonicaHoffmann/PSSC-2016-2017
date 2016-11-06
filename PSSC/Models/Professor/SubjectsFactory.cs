using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics;
using System.Diagnostics.Contracts;
using Models.Generics.Exceptions;

namespace Models.Professor
{
    //factory pt root-ul de agregare Subjects

    public class SubjectsFactory
    {
        public Subjects CreateSubjects(List<Subject.Subject> subjects)
        {
            Subjects _subjects = new Subjects(subjects);
            return _subjects;
        }

        /*
        public Professor CreateProfessor(PlainText name, PositionType positionType)
        {
            Contract.Requires<ArgumentNullException>(name != null, "name is null");
            Contract.Requires<ArgumentInvalidLengthException>(
                    name.ToString().Length >= 2 && name.ToString().Length <= 50,
                    "Numele disciplinei trebuie sa contina intre 2 si 50 de caractere.");
            Contract.Requires<ArgumentNullException>(positionType != null, "positionType is null");
            Professor professor = new Professor(name, positionType);
            return professor;
        }*/
    }
}
