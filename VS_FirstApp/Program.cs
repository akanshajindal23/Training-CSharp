using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationLibrary;

namespace VS_FirstApp
{
    class Program
    {
        //static int Main(string[] args)
        //static int Main()
        //static void Main()

        static void Main(string[] args)
        {
            int result = Calculation.Add(10, 20);
            Console.WriteLine(result);

            Console.WriteLine("Press any key to terminate..");
            Console.ReadLine();
        }
        //static int Add(int firstValue, int secondValue)
        //{
        //    return (firstValue + secondValue);
        //}
    }
}
