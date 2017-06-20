using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge9_1
{
    /// <summary>
    /// Class containinf patterns of the properties
    /// </summary>
    static class Pattern
    {
        public static string EmailPattern = @"^\w+[a-zA-Z0-9]+([-._][a-z0-9]+)*@([a-z0-9]+)\.\w{2,4}";
        public static string PhonePattern = @"(\+92)\s\d{3}-\d{3}-\d{4}";
        public static string WebsitePattern = @"(http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?";
    }
}
