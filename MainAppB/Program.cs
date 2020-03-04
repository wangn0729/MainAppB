using LibA;
using LibB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAppB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is MainB Application");
            var util = new Util();
            Console.WriteLine(util.Output());
            var helper = new Helper();
            Console.WriteLine(helper.Output());
            Console.ReadLine();

        }
    }
}
