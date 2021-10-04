using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedQuestion3
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstClass myClass1 = new FirstClass();
            SecondClass myClass2 = new SecondClass();
            ThirdClass myClass3 = new ThirdClass();

            Console.WriteLine("Please enter distance travel:");
            int dist = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter (1) First Class (2) Second Class (3) Third Class");
            int selectedClass = Int32.Parse(Console.ReadLine());

            if (selectedClass == 1)
            {
                myClass1.TotalCost(dist);
            }
            else if (selectedClass == 2)
            {
                myClass2.TotalCost(dist);

            }
            else if (selectedClass == 3)
            {
                myClass3.TotalCost(dist);
            }
            else
            {
                Console.WriteLine("Wrong Input. Try again");
            }
            Console.ReadLine();
        }
    }

    class FirstClass : MyInterface
    {
        public double CostPerKilo { get; set; }
        public FirstClass()
        {
            CostPerKilo = 300;
        }

        public void TotalCost(int dist)
        {
            double res = dist * CostPerKilo;
            Console.WriteLine("Total cost of journey: $" + res);
        }


    }
    class SecondClass : MyInterface
    {
        public double CostPerKilo { get; set; }

        public SecondClass()
        {
            CostPerKilo = 200;
        }
        public void TotalCost(int dist)
        {
            double res = dist * CostPerKilo;
            Console.WriteLine("Total cost of journey: $" + res);
        }
    }
    class ThirdClass : MyInterface
    {
        public double CostPerKilo { get; set; }

        public ThirdClass()
        {
            CostPerKilo = 100;
        }

        public void TotalCost(int dist)
        {
            double res = dist * CostPerKilo;
            Console.WriteLine("Total cost of journey: $" + res);
        }
    }
}
