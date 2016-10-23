using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Deanship
    {
        private string nameDean;
        private string address;
        private Discipline[] disciplines = new Discipline[100];

        public string NameDean
        {
            get { return nameDean; }
            set { nameDean = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public Discipline[] Disciplines
        {
            get { return disciplines; }
            set { disciplines = value; }
        }

        public Deanship(string nameDecan, string addressDecanat, Discipline[] disciplines)
        {
            this.nameDean = nameDecan;
            this.address = addressDecanat;
            this.disciplines = disciplines;
        }
    }
}
