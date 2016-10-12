using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class IDepartment: IFaculty
    {
        protected string departmentName;
        public string getDepartmentName() { return departmentName; }
        public void setDepartmentName(string departmentName) { this.departmentName = departmentName; }
        public IDepartment(string departmentName, string facultyName, int id, string universityName, string address)
            : base(facultyName, id, universityName, address)
        {
            this.departmentName = departmentName;
        }
        public void giveAnnouncement();
    }
}
