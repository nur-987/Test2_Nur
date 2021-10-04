using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatedQuestn5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyObject Myobj = new MyObject();
            Console.WriteLine("Please enter something");
            object tempObj = Console.ReadLine();
            Myobj.MannipulateObj(tempObj);

            Console.ReadLine();


        }
    }
    class MyObject
    {
        public void MannipulateObj(object obj)
        {
            object result = 0;

            if(obj is string)
            {
                string str = obj as string;
                result = str;

            }
            else if(obj is int)
            {
                int i = (int)obj;
                result = i * i;

            }
            else if (obj is double)
            {
                double i = (double)obj;
                result = i;

            }
            else if (obj is bool)
            {
                bool b = (bool)obj;
                if (b == true)
                {
                    result = false;
                }
                else
                {
                    result = false;
                }

            }

            obj.GetType();
            Console.WriteLine(result);

        }

      

    }
}
/*Boxing and unboxing not working right*/
