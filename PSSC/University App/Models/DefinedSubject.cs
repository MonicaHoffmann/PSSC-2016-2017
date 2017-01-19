using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University_App.Models
{
    public class DefinedSubject
    {
        public Guid Id { get; set; }
        public String SubjectName { get; set; }
        public int Credits { get; set; }
        public String EvaluationType { get; set; }
        public String Professor { get; set; }
    }
}