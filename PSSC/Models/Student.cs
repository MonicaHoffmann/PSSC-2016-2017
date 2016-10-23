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
        private int id;
        private const Int16 availableCredits = 60;
        private string name;
        private YearOfStudy yearOfStudy;
        private Discipline[] disciplines = new Discipline[16];
        private Int16 acquiredCredits = 0;
        private GradeExam[] gradesExam = new GradeExam[16];
        private GradeOngoingActivity[] gradesOngoingActivity = new GradeOngoingActivity[16];
        private PresentAtLaboratoryClass[] presentAtLaboratoryClasses = new PresentAtLaboratoryClass[16];

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public GradeExam[] GradesExam
        {
            get { return gradesExam; }
            set { gradesExam = value; }
        }
        public GradeOngoingActivity[] GradesOngoingActivity
        {
            get { return gradesOngoingActivity; }
            set { gradesOngoingActivity = value; }
        }
        public Int16 AvailableCredits
        {
            get { return availableCredits; }
        }
        public Int16 AcquiredCredits
        {
            get { return acquiredCredits; }
            set { acquiredCredits = value; }
        }
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
