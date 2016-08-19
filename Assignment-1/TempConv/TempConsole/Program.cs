using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TempConsole.TempConverter;

namespace TempConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TempConverter.ServiceClient proxy = new TempConverter.ServiceClient();
            Console.WriteLine("PLEASE ENTER AN INTEGER (CELSIUS TO FAHRENHEIT):");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("FAHRENHEIT VALUE: {0}\n", proxy.c2f(c));

            Console.WriteLine("PLEASE ENTER AN INTEGER (FAHRENHEIT TO CELSIUS):");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CELSIUS VALUE: {0}\n", proxy.f2c(f));

            proxy.Close();
            Console.WriteLine("PRESS <ENTER> TO TERMINATE.");
            Console.ReadLine();
        }
    }
}
