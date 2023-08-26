using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agosto22Clase
{
    public class Ejercice1
    {
        public static void ExecuteExercise()
        {
            // 8. Diseñar un algoritmo que, dados tres números enteros, calcule e imprima
            // el promedio entre ellos. 

            double nota, totNotas = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese la nota obtenida");
                nota = int.Parse(Console.ReadLine());
                totNotas = totNotas + nota;
            }

            Console.WriteLine("El promedio de las notas es " + totNotas / 3);
        }
    }
}

