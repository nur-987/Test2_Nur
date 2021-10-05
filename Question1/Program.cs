using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
    
{/// <summary>
/// wrong number of classes and inteface.
/// as per instrcution:
/// 1 interface 
/// 3 classes
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IFirstClass myClass1 = new MyClass();
            ISecClass myClass2 = new MyClass();
            IThirdClass myClass3 = new MyClass();

            Console.WriteLine("Please enter distance travel:");
            int dist = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter (1) First Class (2) Second Class (3) Third Class");
            int selectedClass = Int32.Parse(Console.ReadLine());

            if(selectedClass == 1)
            {
                myClass1.TotalCost(dist, 100);
            }
            else if(selectedClass == 2)
            {
                myClass2.TotalCost(dist, 50);

            }
            else if(selectedClass == 3)
            {
                myClass3.TotalCost(dist, 25);
            }
            else
            {
                Console.WriteLine("Wrong Input. Try again");
            }
            Console.ReadLine();

        }
    }
}
