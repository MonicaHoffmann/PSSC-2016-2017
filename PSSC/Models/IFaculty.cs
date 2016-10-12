using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class IFaculty: IUniversity
    {
        protected string facultyName;
        public string getFacultyName() { return facultyName; }
        public void setFacultyName(string facultyName) { this.facultyName = facultyName; }
        public IFaculty(string facultyName, int id, string universityName, string address)
            : base(id, universityName, address)
        {
            this.facultyName = facultyName;
        }
        public void giveAnnouncement();
    }
}
