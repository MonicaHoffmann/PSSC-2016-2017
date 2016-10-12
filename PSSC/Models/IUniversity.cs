using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class IUniversity
    {
        protected int id;
        protected string universityName;
        protected string address;
        public int getId() { return id; }
        public string getUniversityName() { return universityName; }
        public string getAddress() { return address; }
        public void setId(int id) { this.id = id; }
        public void setUniversityName(string universityName) { this.universityName = universityName; }
        public void setAddress(string address) { this.address = address; }
        public IUniversity(int id, string universityName, string address)
        {
            this.id = id;
            this.universityName = universityName;
            this.address = address;
        }
        public void giveAnnouncement();
    }
}
