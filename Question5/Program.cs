using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyObject Myobj = new MyObject();
            Myobj.MannipulateObj(4.56);
            Myobj.MannipulateObj("Hello");
            Myobj.MannipulateObj(4);
            Myobj.MannipulateObj(true);

            //object ManipulateObj(object obj);


            //USER input not working
            //Console.WriteLine("PLease enter something to manipulate");
            //var item = Console.ReadLine(); 
            //Console.WriteLine(item.GetType());
            //Myobj.MannipulateObj(item);
        }
    }
    class MyObject
    {
        public void MannipulateObj(string str)
        {
            char[] newArray = str.ToCharArray();
            Array.Reverse(newArray);
            Console.WriteLine(newArray);

            //return to original type
            string newStr = newArray.ToString();
            Console.WriteLine(newStr.GetType());

            Console.ReadLine();
        }
        public void MannipulateObj(int i)
        {
            int newI = i * i;
            Console.WriteLine(newI);
            Console.ReadLine();
        }
        public void MannipulateObj(double dbl)
        {
            string s = dbl.ToString();
            string[] parts = s.Split('.');
            Console.WriteLine(parts[1]);

            //return to original type
            int newInt = Convert.ToInt32(parts[1]);
            Console.WriteLine(newInt.GetType());
            Console.ReadLine();

        }
        public void MannipulateObj(bool b)
        {
            if(b == true)
            {
                Console.WriteLine("false");
            }
            if (b == false)
            {
                Console.WriteLine("true");
            }
            Console.ReadLine();
        }

    }
}
