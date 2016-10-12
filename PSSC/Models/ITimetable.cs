using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum HourPeriod
    {
        EightToTen,
        TenToTwelve,
        TwelveToFourteen,
        FourteenToSixteen,
        SixteenToEighteen,
        EighteenToTwenty
    }
    public enum SessionType
    {
        Curs,
        Laborator,
        Proiect
    }
    public class ITimetable
    {
        protected ISubject subject;
        protected DayOfWeek dayOfWeek;
        protected HourPeriod hourPeriod;
        protected SessionType sessionType;
        public ISubject getSubject() { return subject; }
        public DayOfWeek getDayOfWeek() { return dayOfWeek; }
        public HourPeriod getHourPeriod() { return hourPeriod; }
        public SessionType getSessionType() { return sessionType; }
        public void setSubject(ISubject subject) { this.subject = subject; }
        public void setDayOfWeek(DayOfWeek dayOfWeek) { this.dayOfWeek = dayOfWeek; }
        public void setHourPeriod(HourPeriod hourPeriod) { this.hourPeriod = hourPeriod; }
        public void setSessionType(SessionType sessionType) { this.sessionType = sessionType; }
        public ITimetable(ISubject subject, DayOfWeek dayOfWeek, HourPeriod hourPeriod, SessionType sessionType)
        {
            this.subject = subject;
            this.dayOfWeek = dayOfWeek;
            this.hourPeriod = hourPeriod;
            this.sessionType = sessionType;
        }
    }
}
