using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum EvaluationType {
        Distributed,
        Exam
    }
    public enum ProportionOfOngoingActivityGrade
    {
        AHalf,
        AThird
    }
    public class Discipline
    {
        private int id;
        private string name;
        private Professor professor;
        private Int16 credits;
        private YearOfStudy yearOfStudy;
        private Int16 nrOfAvailablePlaces;
        private EvaluationType evaluationType;
        private ProportionOfOngoingActivityGrade proportionOfOngoingActivityGrade;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public ProportionOfOngoingActivityGrade ProportionOfOngoingActivityGrade
        {
            get { return proportionOfOngoingActivityGrade; }
            set { proportionOfOngoingActivityGrade = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Professor Professor
        {
            get { return professor; }
            set { professor = value; }
        }
        public Int16 Credits
        {
            get { return credits; }
            set { credits = value; }
        }
        public YearOfStudy YearOfStudy
        {
            get { return yearOfStudy; }
            set { yearOfStudy = value; }
        }
        public Int16 NrOfAvailablePlaces
        {
            get { return nrOfAvailablePlaces; }
            set { nrOfAvailablePlaces = value; }
        }
        public EvaluationType EvaluationType
        {
            get { return evaluationType; }
            set { evaluationType = value; }
        }

        public Discipline(string name, Professor professor, Int16 credits)
        {
            this.name = name;
            this.professor = professor;
            this.credits = credits;
        }
    }
}
