using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_Code_Challenges
{
    public static class CountryHelper
    {
        private static List<Country> countries = new List<Country>();

        /// <summary>
        /// Add Country to the list
        /// </summary>
        /// <param name="code">Country Code</param>
        /// <param name="name">Country Name</param>
        /// <param name="capital">Country Capital</param>
        /// <param name="population">Country Popluation</param>
        public static void AddCountry(int code, string name, string capital, long population)
        {
            Country country = new Country();
            country.Code = code;
            country.Name = name;
            country.Capital = capital;
            country.Population = population;
            countries.Add(country);
        }

        /// <summary>
        /// Returns all Countries of the list
        /// </summary>
        /// <returns>list of countries</returns>
        public static List<Country> GetAllCountries()
        {
            var result = (from p in countries
                          select p).ToList<Country>();
            return result;
        }

        /// <summary>
        /// Find Country by Country Code
        /// </summary>
        /// <param name="code">Country Code</param>
        /// <returns>Country Searched</returns>
        public static Country FindCountry(int code)
        {
            var result = (from p in countries
                          where p.Code == code
                          select p).FirstOrDefault();
            return result;
        }

        /// <summary>
        /// Update Country Info
        /// </summary>
        /// <param name="code">Country Code</param>
        /// <param name="name">Country Name</param>
        /// <param name="capital">Country Capital</param>
        /// <param name="population">Country Popluation</param>
        public static void UpdateCountry(int code, string name, string capital, long population)
        {
            var result = (from p in countries
                          where p.Code == code
                          select p).FirstOrDefault();
            if (result != null)
            {
                result.Name = name;
                result.Capital = capital;
                result.Population = population;
            }
        }

        /// <summary>
        /// Delete the Country By Country Code
        /// </summary>
        /// <param name="code">Country Code</param>
        public static void DeleteCountry(int code)
        {
            var result = (from p in countries
                          where p.Code == code
                          select p).FirstOrDefault();
            if (result != null)
            {
                countries.Remove(result);
            }
        }
    }
}
