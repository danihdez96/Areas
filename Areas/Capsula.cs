using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Capsula
    {
        public int basE, altura;

        public void SetbasE(int val1)
        {
            basE = val1;
        }

        public int GetbasE()
        {
            return basE;
        }

        public void Setaltura(int val2)
        {
            altura = val2;
        }

        public int Getaltura()
        {
            return altura;
        }

        public void imp()
        {
            Console.WriteLine("La base es: " + basE);
            Console.WriteLine("La altura es: " + altura);
            Console.WriteLine("El area es: " + basE * altura);
        }
    }
}
