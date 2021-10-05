using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// QUESTION 1
    /// 
    /// </summary>
    class Rectangle
    {
        public int length { get; set; }
        public int breadth { get; set; }
        
    }
    class LandCalc
    {
        public int TotalCost { get; set; }
        public int Cost { get; set; }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            LandCalc landcalc = new LandCalc();
            Rectangle rect = new Rectangle();

            bool x = true;

            while (x)
            {
                Console.WriteLine("Input in the cost of square ft:");
                int inputcost = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Input in length");
                int templength = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Input in breadth");
                int tempbreadth = Int32.Parse(Console.ReadLine());

                int Totalcost = (templength * tempbreadth) * inputcost;
                Console.WriteLine(Totalcost);

                landcalc.TotalCost = Totalcost;
                landcalc.Cost = inputcost;

                rect.breadth = tempbreadth;
                rect.length = templength;

                Console.WriteLine("Would you like to quit? Q-Quit N-No");
                string input = Console.ReadLine();

                if (input == "Q")
                {
                    x = false;
                }
            }
                
            
        }
    }


}
