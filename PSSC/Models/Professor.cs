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
        private String professorName;
        private PositionType positionType;
        private String[] courses = new String[100];   
        
        public String getProfessorName() { return professorName; }
        public PositionType getPositionType() { return positionType; }
        public String getCourse(int index) { return courses[index]; }
        public void setProfessorName(String professorName) { this.professorName = professorName; }
        public void setPositionType(PositionType positionType) { this.positionType = positionType; }
        public void setCourses(String course, int index) { this.courses[index] = course; }
        public Professor(String professorName, PositionType positionType, String[] courses)
        {
            this.professorName = professorName;
            this.positionType = positionType;
            this.courses = courses;
        }
        public void giveGradesToStudents();
        public void receiveProjectsFromStudents();
    }
}
