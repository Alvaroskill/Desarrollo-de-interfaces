using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practica1();
            Practica2();
        }

        #region Practica1

        static void Practica1()
        {

            Console.WriteLine("Introduzca el radio: ");
            int radio = int.Parse(Console.ReadLine());

            const double PI = 3.14;

            double area = PI * Math.Pow(radio, 2);

            Console.WriteLine($"El área del circulo de radio {radio} cm es {area} cm cuadrados");

        }

        #endregion


        #region Practica2

        static void Practica2()
        {


            const int MAYOR_EDAD = 18;
            const string AFIRMACION = "S";

            Console.WriteLine("Introduce la edad: ");
            int edad = int.Parse(Console.ReadLine());



            if (MAYOR_EDAD > edad)
            {

                Console.WriteLine("Eres menor de edad, no puedes conducir");

            }
            else if (MAYOR_EDAD >= edad)
            {

                Console.WriteLine("¿Tienes carnet?");
                string carnet = Console.ReadLine().ToUpper();
                if (carnet.Equals(AFIRMACION))
                {
                    Console.WriteLine("Puedes conducir");
                }
                else
                {
                    Console.WriteLine("No puedes conducir");
                }




            }

            #endregion

        }
    }
}
