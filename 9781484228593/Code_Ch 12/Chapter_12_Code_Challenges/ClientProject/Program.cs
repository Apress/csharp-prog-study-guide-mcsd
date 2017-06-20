using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Proxy object
            SchoolServiceReference.SchoolWebServiceSoapClient client = new SchoolServiceReference.SchoolWebServiceSoapClient();

            //Add new Student
            int result= client.Add(1, "Hamza Ali");//ID is primary key so it should not be same

            if(result>0)
                Console.WriteLine("New Student Added!");
            else
                Console.WriteLine("Error Adding Student");

            //List of all students
            Console.WriteLine("\nAll Students are:\n");
            var students = client.ReadAll();
            foreach (var item in students)
            {
                Console.WriteLine("ID is: "+item.StudentID+" Name is: "+item.StudentName);
            }
            Console.ReadLine();
        }
    }
}
