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

    #region Static KeyWord

    #region static Class
    public static class StaticClass //Cannot be made Object
    {
        //All Properties/Methods/All Must be Static
        public static double Pi = 3.14159; 

        public static double Square(double number)
        {
            return number * number;
        }
    }
    // Usage
    //double area = MathHelper.Pi * MathHelper.Square(5);
    #endregion

    #region static Field 
    public class StaticField
    {
        public static int Count = 0;

        public StaticField()
        {
            Count++;
        }
    }

    // Usage
    //var c1 = new Counter();
    //var c2 = new Counter();
    //Console.WriteLine(Counter.Count); // Output: 2
    #endregion

    #region static Method

    public class StaticMethod
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    // Usage
    // int result = StaticMethod.Add(5, 3); //Valid
    // StaticMethod obj = new StaticMethod();
    // obj.Add(10,20); //InValid.
    #endregion

    #region static Property

    public class StaticPropery
    {
        private static string _appName = "MyApp";

        public static string AppName
        {
            get { return _appName; }
            set { _appName = value; }
        }
    }

    // Usage
    // Console.WriteLine(StaticPropery.AppName); // Output: MyApp
    // StaticPropery.AppName = "NewApp";

    #endregion

    #region static Constructor
    public class StaticConstructor
    {
        public static string LogFile;

        static StaticConstructor()
        {
            LogFile = "log.txt";
        }
    }

    // Usage
    //Console.WriteLine(Logger.LogFile); // Output: log.txt
    #endregion

    #endregion

    #region ref KeyWord

    class refKeyword
    {
        private void SwapTwoNumberFunction(ref int a ,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void refKeywordExample()
        {
            int a = 10; int b = 20;
            int c;
            //SwapTwoNumberFunction(ref a, ref c); Complite Time Error Bcoz C is not initilized
            Console.WriteLine($"a = {a} , b = {b}");
            SwapTwoNumberFunction(ref a, ref b);
            Console.WriteLine($"a = {a} , b = {b}");

        }
    }

    #endregion

    #region ref Vs Out

    public class refvsout
    {
        private void refExample(ref int a)
        {
            a = 10; // modifies original a
        }

        private void outExample(out int a)
        {
            a = 10; //If i reove this , then system will show compile error
        }

        private void ComplexExample(ref int a , ref int b , out int c ,out int d ,ref int[] arr ,out int[] brr)
        {
            a = 100;
            c = a * b;
            d = arr[3];
            arr[1] = 1;
            brr = new int[] { 100,442,4232,3412};
        } 

        public void mainclass()
        {
            int a = 10; int b;

            refExample(ref a);
            outExample(out b);

            int aa = 10; int bb = 20;
            int c, d;
            int[] arr = new int[] { 10,312,31,42,12};
            int[] brr;

            ComplexExample(ref aa, ref bb, out c, out d, ref arr, out brr);

            Console.WriteLine($"a : {aa} ,b : {bb} ,c : {c}, d : {d}");

            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
            foreach (var item in brr)
            {
                Console.WriteLine(item);
            }
        }
    }

    #endregion
}
