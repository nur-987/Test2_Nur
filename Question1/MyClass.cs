using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class MyClass : IFirstClass, ISecClass, IThirdClass
    {
        public double CostPerKilo { get; private set; }

        public void TotalCost(int dist, double cost)
        {
            double Totalcost = dist * cost;
            Console.Write("Cost of the ride is: ");
            Console.WriteLine(Totalcost);
        }

        
    }
}
