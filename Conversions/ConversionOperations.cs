using System;

namespace Conversions
{
    public class ConversionOperations
    {
        public static void TypeConversion()
        {
            // convert user_input to int
            // 1. By int.Parse
            Console.WriteLine("Integer Conversion");
            Console.Write("Enter user input: ");
            int int_num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("By int.Parse : " + int_num1 + "\n");

            // 2. By Convert.ToInt32()
            Console.Write("Enter user input: ");
            int int_num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("By ToInt32 : " + int_num2 + "\n");

            //3. By int.TryParse
            Console.Write("Enter user input: ");
            int number;
            Console.WriteLine("By int.TryParse : " + int.TryParse(Console.ReadLine(), out number) + "\n\n");

            // convert user_input to Float
            Console.WriteLine("Float Conversion");
            //1. By Single.Parse()
            Console.Write("Enter user input: ");
            float float_num1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("By Single.Parse() : " + float_num1 + "\n");

            //2. By float.Parse()
            Console.Write("Enter user input: ");
            float float_num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("By float.Parse() : " + float_num2 + "\n");

            //3. By float.TryParse()
            Console.Write("Enter user_input : ");
            float fnum;
            Console.WriteLine("By float.TryParse : " + float.TryParse(Console.ReadLine(), out fnum) + "\n");

            //4. By Convert.ToSingle()
            Console.Write("Enter user input: ");
            float float_num4 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("By Convert.ToSingle() " + float_num4 + "\n\n");


            // convert user_input to Boolean
            Console.WriteLine("Boolean Conversion");
            // 1. By Convert.ToBoolean()
            Console.Write("Enter user_input : ");
            bool bool_num1 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("By Convert.ToBoolean() : " + bool_num1 + "\n");

            //2. By bool.Parse()
            Console.Write("Enter user_input : ");
            bool bool_num2 = bool.Parse(Console.ReadLine());
            Console.WriteLine("By bool.Parse() : " + bool_num2 + "\n");

            //3
            Console.Write("Enter user_input : ");
            bool bool_num3 = bool.TryParse(Console.ReadLine(), out bool inp);
            Console.WriteLine("By bool.TryParse(.. ,...) : " + bool_num3 + "\n");
        }

    }
}
