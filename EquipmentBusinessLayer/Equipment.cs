using System;

namespace EquipmentInventory
{
    public class Equipment
    {
        private string name;
        private string description;
        private int distanceMovedTillDate = 0;
        private float maintenanceCost = 0;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int DistanceMovedTillDate
        {
            get { return distanceMovedTillDate; }
            set { distanceMovedTillDate = value; }
        }
        public float MaintenanceCost
        {
            get { return maintenanceCost; }
            set { maintenanceCost = value; }
        }
        virtual public void MoveBy(int distance)
        {

        }
        protected void DistanceMoved(int distance)
        {
            this.DistanceMovedTillDate += distance;
        }
    }
}
