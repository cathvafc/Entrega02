using System;

namespace Entrega02
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 5;
            double numero3 = 2.57;
            double suma;
            suma = num1 + numero3;

            Console.WriteLine(suma);
            string valor1 = Console.ReadLine();
            Console.WriteLine("El numero introducido es: " + valor1);           
            int valorint = Convert.ToInt32(valor1);

            Console.ReadKey();
        }
    }
}
