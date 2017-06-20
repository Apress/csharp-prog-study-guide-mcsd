using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();

            // Subscribing the Methods
            std.Passed += OnPassed;
            std.Failed += OnFailed;

            std.ComputerSci = 40;
            std.English = 35;
            std.Math = 20;

            int total = std.TotalMarks;
            Console.WriteLine("Your total marks are {0}", total);
        }


        /// <summary>
        /// Method called on Failing of student
        /// </summary>
        private static void OnFailed()
        {
            Console.WriteLine("You got an 'F' grade.");
        }

        /// <summary>
        /// Mathod called on Passing of Student
        /// </summary>
        private static void OnPassed()
        {
            Console.WriteLine("Congratulation on Passing the Exam.");
        }
    }
}
