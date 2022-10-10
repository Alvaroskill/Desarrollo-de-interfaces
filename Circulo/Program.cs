using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el radio: ");
            int radio = int.Parse(Console.ReadLine());

            const double PI = 3.14;

            double area = PI * Math.Pow(radio, 2);

            Console.WriteLine($"El área del circulo de radio {radio} cm es {area} cm cuadrados");
        }
    }
}
