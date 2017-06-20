using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    public class Laundry : Passenger
    {
        private int _dirtyClothes;
        private string _language;

        public int DirtyClothes
        {
            get { return _dirtyClothes; }
            set { _dirtyClothes = value; }
        }

        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }

        /// <summary>
        /// Clean Cothes Operation of Laundry
        /// </summary>
        /// <param name="customer">customer whose clothes laundry is going to clean</param>
        /// <param name="dirtyClothes">number of dirty clothes customer have</param>
        public void CleanClothes(Customer customer, int dirtyClothes)
        {
            this.DirtyClothes = dirtyClothes;
            Console.WriteLine("Laundry : Ok Sir!! I am going to clean your {0} clothes",dirtyClothes);

            // Go To Clean Clothes
            if (FindTaxi("Laundry Shop, San Fransisco"))
            {
                Console.WriteLine("Laundry : Cleaning the Clothes");
                Console.WriteLine("Laundry : Clothes Cleaned");

                if (FindTaxi("Customer Stop"))
                {
                    Console.WriteLine("Laundry : Here Are Your Cleanes Clothes");
                    customer.DirtyClothes = 0;
                    this.DirtyClothes = 0;
                    Console.WriteLine("Customer : Thanks");
                }
            }

            
        }

        /// <summary>
        /// Find Taxi operation of Laundry
        /// </summary>
        /// <param name="location">location customer is finding the taxi for</param>
        /// <returns>returns true if taxi found and reached</returns>
        public bool FindTaxi(string location)
        {
            Console.WriteLine("Laundry : Hey Taxi!!");
            Console.WriteLine("Laundry : ........Take This Money Lets Go To {0}",location);
            // Randomly Found this Taxi
            TaxiCab taxi = new TaxiCab()
            {
                Passenger = this,
                Language = "English",
                PerKmCharges = 10
            };

            string[] laundryLanguages = this.Language.Split(',');

            if(laundryLanguages.Contains(taxi.Language))
            {
                return taxi.Travel(3, location);
            }
            else
            {
                Console.WriteLine("Taxi Cab : Hey I dont Understand Your Language");
                return false;
            }
            
        }



    }
}
