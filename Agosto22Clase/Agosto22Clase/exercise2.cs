using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agosto22Clase
{
    public class exercise2
    {
        public static void ExecuteExercise()
        {
            //10. Diseñar un algoritmo que imprima el área y el perímetro de un rectángulo ingresando su base y altura. 
            //area es base x altura y el perimetro es mult base x2 y la altura x2 y se suman
            Console.WriteLine("Ingrese el valor de la base");
            int baseRec, h, area, perimetro;
            baseRec = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la altura");
            h = int.Parse(Console.ReadLine());

            area = baseRec * h;
            perimetro = baseRec * 2 + h * 2;

            Console.WriteLine("El area del rectángulo es " + area + ". Y el perimetro es " + perimetro);
        }
    }
}

