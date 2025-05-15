using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompareDelegate minDelegate = GetMin;
            CompareDelegate maxDelegate = GetMax;

            double x = 7.47;
            double y = 5.72;

            Console.WriteLine("Минимум: " + minDelegate(x, y));
            Console.WriteLine("Максимум: " + maxDelegate(x, y));
            Console.Read();

        }
        static double GetMin(double a, double b)
        {
            return (a < b) ? a : b;
        }

        
        static double GetMax(double a, double b)
        {
            return (a > b) ? a : b;
        }

       
        delegate double CompareDelegate(double x, double y);

    }
}
