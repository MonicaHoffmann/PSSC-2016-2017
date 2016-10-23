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
        private string addressDeanship;
        private string[] disciplines = new string[100];
        private string[] professors = new string[100];
        private Int16[] credits = new Int16[100];
        private YearOfStudy[] yearsOfStudy = new YearOfStudy[100];
        private Int16[] numberOfAvailablePlaces = new Int16[100];

        public string NameDean
        {
            get { return nameDean; }
            set { nameDean = value; }
        }

        public string AddressDeanship
        {
            get { return addressDeanship; }
            set { addressDeanship = value; }
        }

        public Deanship(string nameDecan, string addressDecanat, string[] disciplines, string[] professors, Int16[] credits, YearOfStudy[] yearsOfStudy, Int16[] numberOfAvailablePlaces)
        {
            this.nameDean = nameDecan;
            this.addressDeanship = addressDecanat;
            this.disciplines = disciplines;
            this.professors = professors;
            this.credits = credits;
            this.yearsOfStudy = yearsOfStudy;
            this.numberOfAvailablePlaces = numberOfAvailablePlaces;
        }

        public string[] GetDisciplinesForStudent(YearOfStudy yearOfStudy);
    }
}
