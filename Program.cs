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
        //public static void Foo(int x = 0,int y = 1,string s ="abc")
        //{
        //   Console.WriteLine(x + " " + y + " " + s);
        //    Console.ReadLine();
        //}
        //static void Main()
        //{
        //    Foo();
        //}


        //Output stackOverflowException
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


        public class City {
            public string name { get; set; }
            public Country country { get; set; }
        }

        public class Country {
            public string name { get; set; }
            public string abbrev { get; set; }
        }

        static void Main()
        {
            City CT = new City();
            CT.name = "Lost Angeles";

            string labelCity = CT.name;
            //  string labelCountry = CT.country.abbrev;
            string labelCountry = CT?.country?.abbrev ?? "US";

            WriteLine($"Name : {labelCity}");
            WriteLine($"Country : {labelCountry}");
            ReadLine();
        }
    }
}       
