using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentInventory
{
    public static class EquipmentManager
    {
        public static List<Equipment> EquipmentDataList = new List<Equipment>();
        public static List<Equipment> MobileList = new List<Equipment>();
        public static List<Equipment> ImmobileList = new List<Equipment>();
        public static string CreateMobileEquipment(string nameOfEquipment, int noOfWheels)
        {
            Equipment eq = new Mobile(nameOfEquipment, noOfWheels);
            EquipmentDataList.Add(eq);
            MobileList.Add(eq);
            return ("Equipment created successfully!!!\n");

        }
        public static string CreateImmobileEquipment(string nameOfEquipment, int weight)
        {
            Equipment eq = new Immobile(nameOfEquipment, weight);
            EquipmentDataList.Add(eq);
            ImmobileList.Add(eq);
            return ("Equipment created successfully!!!\n");
        }
        public static void DeleteAnEquipment(string nameOfEquipment)
        {
            if (EquipmentDataList.Count == 0)
            {
                Console.WriteLine("Can't perform deletion, there is no equipment in list\n");
            }
            else
            {
                int c = 0;
                foreach (Equipment e in EquipmentDataList)
                {
                    if (e.Name == nameOfEquipment)
                    {
                        EquipmentDataList.Remove(e);
                        c += 1;
                        Console.WriteLine("Equipment deleted successfully!!\n");
                        break;
                    }
                }
                if (c == 0)
                {
                    Console.WriteLine("No such equipment is there in the list");
                }

            }
        }
        public static void MoveAnEquipment(string nameOfEquipment, int moves)
        {
            if (EquipmentDataList.Count == 0) Console.WriteLine("Can't perform move operation, there is no equipment in list");
            else
            {
                foreach (Equipment e in EquipmentDataList)
                {
                    if (e.Name == nameOfEquipment)
                    {
                        e.MoveBy(moves);
                        break;
                    }
                }
                Console.WriteLine("Equipment moved successfully!!\n");
            }
        }
        public static void ShowEquip(string nameOfEquipment)
        {
            int c = 0;
            if (EquipmentDataList.Count == 0) Console.WriteLine("Equipment list is empty\n");
            else
            {
                foreach (Equipment e in EquipmentDataList)
                {

                    if (e.Name == nameOfEquipment)
                    {
                        Console.WriteLine("Name : " + e.Name + "\t\tDescription : " + e.Description + "\t\t" + "Distance moved : " + e.DistanceMovedTillDate + "\t\t" + "Maintenance Cost : " + e.MaintenanceCost + "\n");
                        c += 1;
                        break;
                    }

                }
                if (c == 0)
                {
                    Console.WriteLine("No such equipment is there in the list");
                }

            }
        }
        public static void ListAllEquip()
        {
            if (EquipmentDataList.Count == 0) Console.WriteLine("There is no equipment in the list\n");
            else
            {
                foreach (Equipment e in EquipmentDataList)
                {

                    Console.WriteLine("Name : " + e.Name + "\t\tDescription : " + e.Description + "\t\t" + "Distance moved : " + e.DistanceMovedTillDate + "\t\t" + "Maintenance Cost : " + e.MaintenanceCost);
                }

            }
        }

        public static void MobileEquipments()
        {
            if (MobileList.Count == 0) Console.WriteLine("Mobile Equipment List is empty");
            else
            {
                Console.WriteLine("Mobile Equiments:-");
                MobileList.ForEach((e) => Console.WriteLine("*" + e.Name));
            }
            Console.WriteLine();
        }
        public static void ImmobileEquipments()
        {
            if (ImmobileList.Count == 0) Console.WriteLine("Immobile Equipment List is empty");
            else
            {
                Console.WriteLine("Immobile Equiments:-");
                ImmobileList.ForEach((ie) => Console.WriteLine("*" + ie.Name));
            }
            Console.WriteLine();
        }
        public static void UnmovedEquipments()
        {
            if (EquipmentDataList.Count == 0) Console.WriteLine("There is no equipment in the list\n");
            else
            {
                Console.WriteLine("List of all unmoved equipments");
                foreach (Equipment m in EquipmentDataList.FindAll(e => e.DistanceMovedTillDate == 0))
                {
                    Console.WriteLine(m.Name);
                }

            }
            Console.WriteLine();
        }
        public static void DeleteAllMobileEquipments()
        {
            if (MobileList.Count == 0) Console.WriteLine("No elements to delete, List is already empty");
            else
            {
                MobileList.Clear();
                Console.WriteLine("All mobile equipments deleted successfully!!");
            }
            Console.WriteLine();
        }
        public static void DeleteAllImmobileEquipments()
        {
            if (ImmobileList.Count == 0) Console.WriteLine("No elements to delete, List is already empty");
            else
            {
                ImmobileList.Clear();
                Console.WriteLine("All immobile equipments delete successfully!!");
            }
            Console.WriteLine();
        }
    }
}
