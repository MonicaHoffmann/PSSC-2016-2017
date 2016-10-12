using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class IRoom
    {
        protected string roomNumber;
        public string getRoomNumber() { return roomNumber; }
        public void setRoomNumber(string roomNumber) { this.roomNumber = roomNumber; }
        public IRoom(string roomNumber)
        {
            this.roomNumber = roomNumber;
        }
        public void reserveRoom();
    }
}
