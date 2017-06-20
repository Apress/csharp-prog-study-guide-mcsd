using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class Car : Vehicle
    {
        private const int maxSpeed = 350; // maximum speed of Car
        private const int totalWheels = 4; // maximum total wheels of Car

        public override int Speed
        {
            get
            {
                return _speed;
            }

            set
            {
                if (value <= maxSpeed)
                {
                    _speed = value;
                }
                else
                {
                    Console.WriteLine("Car's maximum speed is : {0}", maxSpeed);
                }
            }
        }

        public override int Wheels
        {
            get
            {
                return _wheels;
            }

            set
            {
                if (value <= totalWheels)
                {
                    _wheels = value;
                }
                else
                {
                    Console.WriteLine("Car's Total Wheels are : {0}", totalWheels);
                }
            }
        }

        public override void Run()
        {
            Console.WriteLine("Car is Running with {0} Wheels and with Speed of {1}", _wheels, _speed);
        }
    }
}
