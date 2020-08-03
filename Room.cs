using System;
using System.Collections.Generic;
using System.Text;

namespace oop_w05
{
    class Room
    {
        private string roomCode;
        private string roomName;
        private string roomWidth;
        private string roomLength;
        private string roomType;
        private Building roomBuilding;

        public string RoomCode {
            get { return this.roomCode; }
            set { this.roomCode = value; }
        }
        public string RoomName {
            get { return this.roomName; }
            set { this.roomName = value; }
        }
        public string RoomWidth {
            get { return this.roomWidth; }
            set { this.roomWidth = value; }
        }
        public string RoomLength {
            get { return this.roomLength; }
            set { this.roomLength = value; }
        }
        public string RoomType {
            get { return this.roomType; }
            set { this.roomType = value; }
        }
        public Building RoomBuilding {
            get { return this.roomBuilding; }
            set { this.roomBuilding = value; }
        }
        public Room() { }
        public Room(string rc,string rn,string rw,string rl,string rt,Building rb) {
            this.RoomCode = rc;
            this.RoomName = rn;
            this.RoomWidth = rw;
            this.RoomLength = rl;
            this.RoomType = rt;
            this.RoomBuilding = rb;
        }
        public override string ToString()
        {
            return this.RoomCode + " " + this.RoomName + " " +this.RoomBuilding.ToString()
                + " Lat " + this.RoomBuilding.BuildingLat + " Long " + this.RoomBuilding.BuildingLong;
        }

    }
}
