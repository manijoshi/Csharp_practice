using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentInventory
{

    public class Program
    {
        public static void Main()
        {
            bool flag = true;
            while (flag)
            {
                //Task1
                Console.WriteLine("Welcome to Equipment Inventory Center");
                Console.WriteLine("Enter 1 to Create Mobile Equipment");
                Console.WriteLine("Enter 2 to Create Immobile Equipment");
                Console.WriteLine("Enter 3 to Move An Equipment");
                Console.WriteLine("Enter 4 to List All Equipment");
                //Task6
                Console.WriteLine("Enter 5 to Delete An Equipment");
                Console.WriteLine("Enter 6 to Show An Equipment");
                Console.WriteLine("Enter 7 to list all Mobile Equipments");
                Console.WriteLine("Enter 8 to list all Immobile Equipments");
                Console.WriteLine("Enter 9 to list all Unmoved Equipments");
                Console.WriteLine("Enter 10 to Delete all Mobile Equipments");
                Console.WriteLine("Enter 11 to Delete all Immobie Equipments");
                Console.WriteLine("Enter 0 to Exit");
                int opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.Write("Name of Equipment: ");
                        string nameOfMobileEquipment = Console.ReadLine();
                        Console.Write("Number of wheels: ");
                        int noOfWheels = int.Parse(Console.ReadLine());
                        Console.WriteLine(EquipmentInventory.EquipmentManager.CreateMobileEquipment(nameOfMobileEquipment, noOfWheels));
                        break;
                    case 2:
                        Console.Write("Name of Equipment: ");
                        string nameOfImmobileEquipment = Console.ReadLine();
                        Console.Write("Weight: ");
                        int weight = int.Parse(Console.ReadLine());
                        Console.WriteLine(EquipmentInventory.EquipmentManager.CreateImmobileEquipment(nameOfImmobileEquipment, weight));
                        break;

                    case 3:
                        Console.Write("Name of Equipment: ");
                        string nameOfEquipment1 = Console.ReadLine();
                        Console.Write("No. of moves: ");
                        int distanceToMove = int.Parse(Console.ReadLine());
                        EquipmentInventory.EquipmentManager.MoveAnEquipment(nameOfEquipment1, distanceToMove);
                        break;
                    case 4:
                        EquipmentInventory.EquipmentManager.ListAllEquip();
                        break;
                    case 5:
                        Console.Write("Name of Equipment: ");
                        string nameOfEquipment = Console.ReadLine();
                        EquipmentInventory.EquipmentManager.DeleteAnEquipment(nameOfEquipment);
                        break;
                    case 6:
                        Console.Write("Enter name of Equipment: ");
                        string nameOfEquipment2 = Console.ReadLine();
                        EquipmentInventory.EquipmentManager.ShowEquip(nameOfEquipment2);
                        break;
                    case 7:

                        EquipmentInventory.EquipmentManager.MobileEquipments();
                        break;
                    case 8:
                        EquipmentInventory.EquipmentManager.ImmobileEquipments();
                        break;
                    case 9:
                        EquipmentInventory.EquipmentManager.UnmovedEquipments();
                        break;
                    case 10:
                        EquipmentInventory.EquipmentManager.DeleteAllMobileEquipments();
                        break;
                    case 11:
                        EquipmentInventory.EquipmentManager.DeleteAllImmobileEquipments();
                        break;
                    case 0:
                        flag = false;
                        break;
                }
            }
        }
    }
}