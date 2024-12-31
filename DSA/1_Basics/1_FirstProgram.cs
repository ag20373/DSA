using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA._1_Basics
{
    class _1_FirstProgram
    {
        public _1_FirstProgram()
        {
            StringDisplayConstructor();
        }
        public static void StringDisplayDirectly(string Value)
        {
            Console.WriteLine(Value);
        }
        public  void StringDisplayConstructor()
        {
            Console.WriteLine("Called From Constructor");
        }
        public void StringDisplayObject(string Value)
        {
            Console.WriteLine(Value);
        }
    }   
}
