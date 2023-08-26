namespace Agosto22Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija la opción 1, 2 o 3");
            string opc;
            opc = Console.ReadLine();
            Console.WriteLine("La opcion es " + opc);
            switch (opc)
            {
                case "1":
                    Ejercice1.ExecuteExercise();
                    break;
                case "2":
                    exercise2.ExecuteExercise();
                    break;
                case "3":
                    exercise3.ExecuteExercise();
                    break;
            }
        }
    }
}
