using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Challenge2
{
    public class TaxiCab
    {
        private decimal _perKmCharges;
        public decimal PerKmCharges
        {
            get
            {
                return _perKmCharges;
            }
            set
            {
                if (value > 0)
                {
                    _perKmCharges = value;
                }
                else
                {
                    Console.WriteLine("Negative Or Zero Charges Not Allowed");
                }
            }
        }

        private Passenger _passenger = null;

        public Passenger Passenger
        {
            get
            {
                return _passenger;
            }
            set
            {
               _passenger = value;
            }
        }

        private string _language;

        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }

        /// <summary>
        /// Travel Method Of Taxi Cab
        /// </summary>
        /// <param name="distanceInKm">distance in Km</param>
        /// <param name="location">location where you wanna go</param>
        /// <returns>returns true if reached after travelling else false in any other case</returns>
        public bool Travel(decimal distanceInKm, string location)
        {
            if (Passenger != null)
            {
                decimal actualCharges = distanceInKm * _perKmCharges;

                //Passenger.Money -= actualCharges;


                if (actualCharges == Passenger.Money)
                {
                    Passenger.Money -= actualCharges;
                    Move(location);
                }
                else if (actualCharges < Passenger.Money)
                {
                    decimal remainingMoney = (Passenger.Money - (distanceInKm * PerKmCharges));
                    Console.WriteLine("TaxiCab : Your Money is greater than the Total Charges!!");
                    Console.WriteLine("TaxiCab : Take Your ${0} back", remainingMoney);
                    Passenger.Money -= actualCharges;
                    Move(location);
                }
                else
                {
                    Console.WriteLine("TaxiCab : We cant move!! Take Your Money!! Your money is not enough!!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("TaxiCab : No Passenger Inside!!Cant Move");
                return false;
            }

            return true;
        }

        public void Move(string location)
        {
            Console.WriteLine("TaxiCab : Sit Inside!! Lets Go...");
            Thread.Sleep(2000);
            Console.WriteLine("TaxiCab : Reached To {0}!!", location);
            this.Passenger = null;
        }
    }
}
