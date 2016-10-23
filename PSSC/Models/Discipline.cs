using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Discipline
    {
        private string name;
        private Professor professor;
        private Int16 credits;

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

        public Discipline(string name, Professor professor, Int16 credits)
        {
            this.name = name;
            this.professor = professor;
            this.credits = credits;
        }
    }
}
