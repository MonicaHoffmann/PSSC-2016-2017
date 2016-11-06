using Models.Generics;
using Models.Generics.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Models.Subject
{
    //informatii despre o materie; numele, nr de credite, profesorul, proportia activitatii pe parcurs,
    //tipul de evaluare; clasa poate fi definita printr-un constructor, iar ulterior se mai pot seta
    //doar profesorul sau activitatea pe parcurs

    public class SubjectInformation
    {
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }
        public Professor.Professor Professor { get; internal set; }
        public Proportion ActivityProportion { get; internal set; }
        public EvaluationType Evaluation { get; internal set; }

        public SubjectInformation()
        {

        }

        public SubjectInformation(PlainText name, Credits credits, EvaluationType type, Proportion activity)
        {
            Contract.Requires<ArgumentNullException>(name != null, "name is null");
            Contract.Requires<ArgumentInvalidLengthException>(
                    name.ToString().Length >= 2 && name.ToString().Length <= 50,
                    "Numele disciplinei trebuie sa contina intre 2 si 50 de caractere.");
            Contract.Requires<ArgumentNullException>(credits != null, "credits is null");
            Contract.Requires<ArgumentInvalidCountOfCredits>(credits.Count >= 0 && credits.Count <= 30, 
                "credits incorrect");
            Contract.Requires<ArgumentNullException>(type != null, "type is null");
            Contract.Requires<ArgumentNullException>(activity != null, "activity is null");
            Name = name;
            Credits = credits;
            Evaluation = type;
            ActivityProportion = activity;
        }

        public SubjectInformation(PlainText name, Credits credits, EvaluationType type, Proportion activity, Professor.Professor professor) 
            : this(name, credits, type, activity)
        {
            Professor = professor;
        }

        public void SetProfessor(Professor.Professor professor)
        {
            Professor = professor;
        }

        public void SetActivityProportion(Proportion proportion)
        {
            ActivityProportion = proportion;
        }
    }
}
