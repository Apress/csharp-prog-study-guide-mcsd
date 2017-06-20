using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalStudents = 0;
            
            // Take Number of total students

            Console.Write("Enter Total Students : ");
            totalStudents = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string[] studentNames = new string[totalStudents];

            int[] englishMarks = new int[totalStudents];
            int[] mathMarks = new int[totalStudents];
            int[] computerMarks = new int[totalStudents];

            int[] totalMarks = new int[totalStudents];

            // Loop Taking Student Information

            for (int i = 0; i < totalStudents; i++)
            {
                Console.Write("Enter Student Name : ");
                studentNames[i] = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Enter English Marks (Out Of 100) : ");
                englishMarks[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Enter Math Marks : ");
                mathMarks[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Enter Computer Marks : ");
                computerMarks[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("*********************************************");

                totalMarks[i] = englishMarks[i] + mathMarks[i] + computerMarks[i];
            }

            //Sorting in descending order

            SortTotalMarksInDescendingOrder(studentNames,totalMarks);

            Console.WriteLine("****************Report Card********************");

            // Displaying Student Report

            for (int i = 0; i < totalStudents; i++)
            {
                Console.Write("Student Name: {0}, Position: {1}, Total: {2}/300",studentNames[i],i+1,totalMarks[i]);
                Console.WriteLine();
                Console.WriteLine("****************************************");
            }

            Console.ReadLine();

        }

        /// <summary>
        /// Sort Total Marks and ReOrder Student Names According to Total marks sorting
        /// </summary>
        /// <param name="studentNames">Student Names Array</param>
        /// <param name="totalMarks">Total Marks Array</param>
        private static void SortTotalMarksInDescendingOrder(string[] studentNames,int[] totalMarks)
        {
            int n = totalMarks.Length;

            int totalMarksTemp = 0;
            string studentNamesTemp = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (totalMarks[i] < totalMarks[j])
                    {
                        totalMarksTemp = totalMarks[i];
                        totalMarks[i] = totalMarks[j];
                        totalMarks[j] = totalMarksTemp;

                        studentNamesTemp = studentNames[i];
                        studentNames[i] = studentNames[j];
                        studentNames[j] = studentNamesTemp;
                    }

                }
            }
        }
    }
}
