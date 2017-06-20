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
            // Filling Customer Information

            Customer customer = new Customer()
            {
                Language = "English",
                DirtyClothes = 5
            };

            // Filling Laundry Information

            Laundry laundry = new Laundry()
            {
                Language = "French,English",
                Money = 66
            };

            // cutsomer Saying Laundry to Clean the clothes
            customer.CleanMyClothes(laundry);

            Console.WriteLine("**************Summary*****************");
            Console.WriteLine("Customer Dirty Clothes : {0}",customer.DirtyClothes);
            Console.WriteLine("Laundry Total Money : {0}",laundry.Money);

            Console.ReadLine();
        }
    }
}
