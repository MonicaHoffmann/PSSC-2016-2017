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
    public class IProfessor
    {
        protected string professorName;
        protected PositionType positionType;
        public string getProfessorName() { return professorName; }
        public PositionType getPositionType() { return positionType; }
        public void setProfessorName(string professorName) { this.professorName = professorName; }
        public void setPositionType(PositionType positionType) { this.positionType = positionType; }
        public IProfessor(string professorName, PositionType positionType)
        {
            this.professorName = professorName;
            this.positionType = positionType;
        }
        public void giveGradesToStudents();
        public void receiveProjectsFromStudents();
    }
}
