using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Decanat
    {
        private String nameDecan;
        private String addressDecanat;
        private String[] courses = new String[100];
        private String[] professors = new String[100];
        private Int16[] credits = new Int16[100];
        private YearOfStudy[] yearsOfStudy = new YearOfStudy[100];
        private Int16[] numberOfAvailablePlaces = new Int16[100];

        public String getNameDecan() { return nameDecan; }
        public String getAddressDecanat() { return addressDecanat; }
        public String getCourses(int index) { return courses[index]; }
        public String getProfessors(int index) { return professors[index]; }
        public Int16 getCredits(int index) { return credits[index]; }
        public YearOfStudy getYearsofStudy(int index) { return yearsOfStudy[index]; }
        public Int16 getNumberOfAvailablePlaces(int index) { return numberOfAvailablePlaces[index]; }
        public void setNameDecan(String nameDecan) { this.nameDecan = nameDecan; }
        public void setAddressDecanat(String addressDecanat) { this.addressDecanat = addressDecanat; }
        public void setCourses(String course, int index) { this.courses[index] = course; }
        public void setProfessor(String professor, int index) { this.professors[index] = professor; }
        public void setCredits(Int16 credit, int index) { this.credits[index] = credit; }
        public void setYearsOfStudy(YearOfStudy yearOfStudy, int index) { this.yearsOfStudy[index] = yearOfStudy; }
        public void setNumberOfAvailablePlaces(Int16 numberOfAvailablePlaces, int index) { this.numberOfAvailablePlaces[index] = numberOfAvailablePlaces; }
        
        public Decanat(String nameDecan, String addressDecanat, String[] courses, String[] professors, Int16[] credits, YearOfStudy[] yearsOfStudy, Int16[] numberOfAvailablePlaces)
        {
            this.nameDecan = nameDecan;
            this.addressDecanat = addressDecanat;
            this.courses = courses;
            this.professors = professors;
            this.credits = credits;
            this.yearsOfStudy = yearsOfStudy;
            this.numberOfAvailablePlaces = numberOfAvailablePlaces;
        }

        public String[] getCoursesForStudent(YearOfStudy yearOfStudy);
    }
}
