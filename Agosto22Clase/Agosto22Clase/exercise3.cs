
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agosto22Clase
{
    internal class exercise3
    {
        public static void ExecuteExercise()
        {
            //11. Realice un algoritmo que calcule el volumen de un cilindro a partir de los valores de su radio y altura. 

            double r, h, volCilindro;
            Console.WriteLine("Ingrese el radio del Cilindro");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del Cilindro");
            h = int.Parse(Console.ReadLine());

            double pi = 3.14;
            volCilindro = (pi * r * r * h);
            Console.WriteLine("El volumen del cubo es: " + volCilindro);
        }
    }
}
