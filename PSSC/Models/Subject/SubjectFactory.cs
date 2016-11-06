using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Models.Subject
{
    //factory pt root-ul de agregare subject

    public class SubjectFactory
    {
        public Subject CreateSubject (SubjectInformation subjectInfo) {
            Contract.Requires<ArgumentNullException>(subjectInfo != null);
            
            Subject subject = new Subject(subjectInfo);
            return subject;
        }
    }
}
