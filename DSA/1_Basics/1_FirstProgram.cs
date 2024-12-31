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
}
