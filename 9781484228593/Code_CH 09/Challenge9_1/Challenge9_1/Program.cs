using System;
using System.Text.RegularExpressions;

namespace Challenge9_1
{
    class Program
    {
        /*
         * Examples of Right strings
         * Name : Lakhtey Hussnain
         * Email : lakhtey_hussnain@hotmail.com
         * Phone : +92 313-752-4824
         * WebSite : http://www.example.com  
         */
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.Write("Enter your name: ");
            person.Name = Console.ReadLine();

            Console.Write("\n Enter your Email: ");
            person.Email = Console.ReadLine();

            Console.Write("\n Enter your Phone: ");
            person.Phone = Console.ReadLine();

            Console.Write("\n Enter your Website: ");
            person.Web = Console.ReadLine();

            try
            {
                bool isValidated = Validate(person);

                if(isValidated)
                {
                    Console.WriteLine("Information is correct");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();


        }

        /// <summary>
        /// Validate Object Properties
        /// </summary>
        /// <param name="p">Object whose properties needs to be validated</param>
        /// <returns>returns true if all validated otherwise false</returns>
        private static bool Validate(Person p)
        {

            if (Regex.IsMatch(p.Email, Pattern.EmailPattern) != true)
            {
                throw new ArgumentException("Email is invalid", "Email");
            }
            if (Regex.IsMatch(p.Phone, Pattern.PhonePattern) != true)
            {
                throw new ArgumentException("Phone is invalid", "Phone");
            }
            if (Regex.IsMatch(p.Web, Pattern.WebsitePattern) != true)
            {
                throw new ArgumentException("Web is invalid", "Web");
            }

            return true;

        }
    }
}
