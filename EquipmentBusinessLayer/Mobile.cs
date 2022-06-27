using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentInventory
{
    class Mobile : Equipment
    {
        private int numberOfWheels;
        public int NumberOfWheels
        {
            get { return numberOfWheels; }
            set { numberOfWheels = value; }
        }
        override public void MoveBy(int distanceToMove)
        {
            this.MaintenanceCost += distanceToMove * (this.NumberOfWheels);
            this.DistanceMoved(distanceToMove);
        }
        public override string ToString()
        {
            return string.Format(this.Name, this.numberOfWheels, this.MaintenanceCost, this.DistanceMovedTillDate);
        }
        public Mobile(string namee, int noOfWheel)
        {
            this.Name = namee;
            this.numberOfWheels = noOfWheel;
            this.Description = Convert.ToString(noOfWheel + " wheels");

        }
    }
}
