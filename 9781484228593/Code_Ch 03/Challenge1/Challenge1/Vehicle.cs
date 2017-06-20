using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class Vehicle
    {
        protected int _speed;

        public virtual int Speed { get; set; }


        protected int _wheels;

        public virtual int Wheels { get; set; }

        // Virtual Run Method
        public virtual void Run()
        {
            Console.WriteLine("Vehicle is Running with {0} Wheels and with Speed of {1}",_wheels,_speed);
        }
    }
}
