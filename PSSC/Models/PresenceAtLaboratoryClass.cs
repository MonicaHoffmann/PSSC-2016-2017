using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PresenceAtLaboratoryClass
    {
        private int id;
        private bool presence;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public bool Presence
        {
            get { return presence; }
            set { presence = value; }
        }
    }
}
