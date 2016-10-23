using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum PositionType
    {
        Asistent,
        Lector,
        Conferentiar,
        Profesor
    }
    public class Professor
    {
        private int id;
        private string name;
        private PositionType positionType;
        private Discipline[] disciplines = new Discipline[16];

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public PositionType PositionType
        {
            get { return positionType; }
            set { positionType = value; }
        }
        public Discipline[] Disciplines
        {
            get { return disciplines; }
            set { disciplines = value; }
        }
       
        public Professor(string professorName, PositionType positionType, Discipline[] disciplines)
        {
            this.name = professorName;
            this.positionType = positionType;
            this.disciplines = disciplines;
        }
    }
}
