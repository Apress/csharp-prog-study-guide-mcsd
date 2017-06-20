using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        /// <summary>
        /// Chapter 1 : Fundamentals of C# 
        /// Challenge 1 : - Develop an Arithemetic Calculator Application
        /// Developer : Syed Lakhtey Hussnain
        /// </summary>
        static void Main(string[] args)
        {
            bool isContinued = true;

            // This Loop manages the Menu Iteration
            while (isContinued)
            {
                int option = 0;

                Console.Clear(); // Clears the Screen

                Console.WriteLine("Press any following key to perform an arithmetic operation:");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");

                option = int.Parse(Console.ReadLine());

                

                switch (option)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Subtract();
                        break;
                    case 3:
                        Multiply();
                        break;
                    case 4:
                        Divide();
                        break;
                    default:
                        Console.WriteLine("Wrong Choice!");
                        break;
                }

                Console.WriteLine("Do you want to continue again (Y/N)?");
                string userInput = Console.ReadLine();

                if(userInput.ToUpper() == "N")
                {
                    isContinued = false;
                }
            }

        }

        /// <summary>
        /// Add Two Values
        /// </summary>
        public static void Add()
        {
            Console.WriteLine("Enter Value 1");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value 2");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", value1, value2, value1 + value2);
        }

        /// <summary>
        /// Subtract Two Values
        /// </summary>
        public static void Subtract()
        {
            Console.WriteLine("Enter Value 1");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value 2");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} - {1} = {2}", value1, value2, value1 - value2);
        }

        /// <summary>
        /// Multiply Two Values
        /// </summary>
        public static void Multiply()
        {
            Console.WriteLine("Enter Value 1");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value 2");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} * {1} = {2}", value1, value2, value1 * value2);
        }

        /// <summary>
        /// Divide Two Values
        /// </summary>
        public static void Divide()
        {
            Console.WriteLine("Enter Value 1");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value 2");
            int value2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} / {1} = {2}", value1, value2, value1 / value2);
        }

    }
}
