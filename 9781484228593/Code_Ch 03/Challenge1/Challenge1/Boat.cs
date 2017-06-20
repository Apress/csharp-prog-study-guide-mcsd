using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Boat : Vehicle
    {
        private const int maxSpeed = 200; // maximum speed of Boat
        private const int totalWheels = 0; // maximum total wheels of Boat

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
                    Console.WriteLine("Boat's maximum speed is : {0}", maxSpeed);
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
                    Console.WriteLine("Boat's Total Wheels are : {0}", totalWheels);
                }
            }
        }

        public override void Run()
        {
            Console.WriteLine("Boat is Floating with {0} Wheels and with Speed of {1}", _wheels, _speed);
        }
    }
}
