using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    public class Customer
    {
        private string _language;
        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }

        private int _dirtyClothes;

        public int DirtyClothes
        {
            get { return _dirtyClothes; }
            set { _dirtyClothes = value; }
        }

        /// <summary>
        /// Clean Clothes Method of Customer
        /// </summary>
        /// <param name="laundry">Laundry Object to fullfill the order</param>
        public void CleanMyClothes(Laundry laundry)
        {

            Console.WriteLine("Customer : Hey Clean My Clothes");

            string[] laundryLanguages = laundry.Language.Split(',');

            if (laundryLanguages.Contains(this.Language))
            {
                laundry.CleanClothes(this, DirtyClothes);
            }
            else
            {
                Console.WriteLine("Laundry : Hey I dont understand your language");
            }
        }
    }
}
