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
        private string professorName;
        private PositionType positionType;
        private string[] disciplines = new string[100];

        public string ProfessorName
        {
            get { return professorName; }
            set { professorName = value; }
        }
        public PositionType PositionType
        {
            get { return positionType; }
            set { positionType = value; }
        }
        public string[] Disciplines
        {
            get { return disciplines; }
            set { disciplines = value; }
        }
       
        public Professor(string professorName, PositionType positionType, string[] disciplines)
        {
            this.professorName = professorName;
            this.positionType = positionType;
            this.disciplines = disciplines;
        }
        public void GiveGradesToStudents();
        public void ReceiveProjectsFromStudents();
    }
}
