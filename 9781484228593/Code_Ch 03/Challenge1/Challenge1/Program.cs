using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    enum State
    {
        Air = 1,
        Road = 2,
        Water = 3
    };

    class Program
    {
        static void Main(string[] args)
        {

            #region Initializing Objects
            Vehicle v = new Vehicle();

            Jet jet = new Jet()
            {
                Wheels = 8,
                Speed = 900
            };

            Car car = new Car()
            {
                Wheels = 4,
                Speed = 300
            };

            Boat boat = new Boat()
            {
                Wheels = 0,
                Speed = 100
            }; 
            #endregion

            Console.WriteLine("Enter State of Vehicle");
            Console.WriteLine("1 - Air");
            Console.WriteLine("2 - Road");
            Console.WriteLine("3 - Water");

            // Parsing integer to State Enum
            State s = (State)int.Parse(Console.ReadLine());

            // Checking enum values to assign right object
            switch (s)
            {
                case State.Air:
                    v = jet;
                    break;
                case State.Road:
                    v = car;
                    break;
                case State.Water:
                    v = boat;
                    break;
                default:
                    Console.WriteLine("Wrong Option");
                    break;
            }

            // Call Run Method
            v.Run();

            Console.ReadLine();


        }
    }
}
