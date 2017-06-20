using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5_Challenge1
{
    class Student
    {
        public event Action Passed;
        public event Action Failed;

        private int _totalmarks = 0;
        private int _compSci;
        private int _math;
        private int _english;

        public int TotalMarks
        {
            private set
            {
                this._totalmarks = value;                
            }
            get
            {                
                if (this._totalmarks >= 75)
                {
                    if (Passed != null)     // This check is very useful when the Event is not subscribed
                        Passed();
                }
                else
                {
                    if (Failed != null)    // This check is very useful when the Event is not subscribed
                        Failed();
                }
                return this._totalmarks;
            }
        }

        public int ComputerSci
        {
            set
            {
                this._compSci = value;
                this._totalmarks += this.ComputerSci;

            }
            get { return this._compSci; }
        }

        public int Math
        {
            set
            {
                this._math = value;
                this._totalmarks += this._math;

            }
            get { return this._math; }
        }

        public int English
        {
            set
            {
                this._english = value;
                this._totalmarks += this._english;

            }
            get { return this._english; }
        }


    }
}
