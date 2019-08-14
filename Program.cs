using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace testCode
{
    class Program
    {
        public static void Foo(int x = 0, int y = 1, string s = "abc")
        {
            WriteLine(x + " " + y + " " + s);
        }
        #region Output stackOverflowException
        //private static int oddSigma(int s)
        //{
        //    if (s == 1)
        //        return s;
        //     return s + oddSigma(s - 2);
        //}
        //static void Main(string[] args)
        //{
        //    WriteLine(Program.oddSigma(8));
        //    _ = ReadLine();
        //}

        #endregion

        static void Main()
        {
            City CT = new City();
            CT.name = "Los Angeles";

            string labelCity = CT.name;
            string labelCountry1 = CT?.country?.abbrev ?? "US";
            //or
            string labelCountry2 = null;
            if (CT != null)
            {
                if (CT.country == null)
                    labelCountry2 = "US";
            }
            //or
            string labelCountry3 = CT.country != null ? (CT.country.abbrev != null ? CT.country.abbrev : "US") : "US";

            WriteLine($"Name : {labelCity}");
            WriteLine($"Country : {labelCountry1}");
            WriteLine($"Country : {labelCountry2}");
            WriteLine($"Country : {labelCountry3}");
            WriteLine("----------------------------");
            Foo();
            _ = ReadLine();

        }
    }
}       
