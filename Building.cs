using System;
using System.Collections.Generic;
using System.Text;

namespace oop_w05
{
    class Building
    {
        private string buildingCode;
        private string buildingName;
        private string buildingLat;
        private string buildingLong;
        public string BuildingCode {
            get { return buildingCode; }
            set { this.buildingCode = value; }
        }
        public string BuildingName {
            get { return buildingName; }
            set { this.buildingName = value; }
        }
        public string BuildingLat {
            get { return buildingLat; }
            set { this.buildingLat = value; }
        }
        public string BuildingLong {
            get { return buildingLong; }
            set { this.buildingLong = value; }
        }
        public Building() { }
        public Building(string bc,string bn,string blat,string blong) {
            this.BuildingCode = bc;
            this.BuildingName = bn;
            this.BuildingLat = blat;
            this.BuildingLong = blong;
        }
        public override string ToString()
        {
            return this.BuildingCode + " " + this.BuildingName;
        }
    }
}
