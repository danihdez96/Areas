using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            Capsula obj1 = new Capsula();
            Class1 obj2 = new Class1();
            obj1.basE = 9;
            obj1.altura = 12;
            obj1.imp();

            obj2.lado = 5;
            obj2.imp();
            Console.ReadKey();
        }
    }
}
