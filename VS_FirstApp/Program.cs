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
            char op;
            Console.WriteLine("Please enter the choice 1,2,3,4 : ");
            string value = Console.ReadLine();
          //int choice = Convert.ToInt32(value);
            int choice = int.Parse(value);
            do
            {
                Console.WriteLine("Would you like to continue");
                string option = Console.ReadLine();
                op = Convert.ToChar(option);
            }


            while (op.Equals('y') || op.Equals('Y))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter first number");
                        string value1 = Console.ReadLine();
                        int firstnum = Convert.ToInt32(value1);

                        Console.WriteLine("Enter second number");
                        string value2 = Console.ReadLine();
                        int secondnum = Convert.ToInt32(value2);

                        int resAdd = Calculation.Add(firstnum, secondnum);
                        Console.WriteLine($"Addition of two numbers are: { resAdd}");
                        Console.ReadLine();
                        //   Console.WriteLine("Would you like to continue..");
                        break;

                    case 2:
                        Console.WriteLine("Enter first number");
                        string val1 = Console.ReadLine();
                        int firstnum1 = Convert.ToInt32(val1);
                        Console.WriteLine("Enter second number");
                        string val2 = Console.ReadLine();
                        int secondnum1 = Convert.ToInt32(val2);
                        int resSub = Calculation.Subtract(firstnum1, secondnum1);
                        Console.WriteLine($"Subtraction of the given numbers are: {resSub}");
                        Console.ReadLine();
                        Console.WriteLine("Would you like to continue..");
                        break;
                }
               
            }
            
        }

    }
}
