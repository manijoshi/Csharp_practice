using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentInventory
{
    class Immobile : Equipment
    {
        float weight;
        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        override public void MoveBy(int distanceToMove)
        {
            this.MaintenanceCost += distanceToMove * (this.weight);
            this.DistanceMoved(distanceToMove);
        }
        public override string ToString()
        {
            return string.Format(this.Name, this.Weight, this.MaintenanceCost, this.DistanceMovedTillDate);
        }
        public Immobile(string name, float weight)
        {
            this.Name = name;
            this.weight = weight;
            this.Description = Convert.ToString(weight + "kg");
        }
    }
}
