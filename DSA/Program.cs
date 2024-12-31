using DSA._1_Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1_Basics
            _1_FirstProgram.StringDisplayDirectly("Called Using Static");
            _1_FirstProgram obj = new _1_FirstProgram();
            obj.StringDisplayObject("Called Using Object");
            #endregion
        }
    }
}
