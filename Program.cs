using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá usuário, vou ajudá-lo a coverter °F para °C. Digite uma tecla para continuar:");

            Console.ReadKey();



            Console.WriteLine("Digite o valor em °F:");

            double F = double.Parse (Console.ReadLine ());



            double valor1 = 1.8; // vl = valor 

            double valor2  = 32; // vl2 = outro valor



            Console.Write(F + " °F equivalem a: ");

            Console.Write(F - valor2 / valor1 );

            Console.WriteLine(" °C.");

            

            Console.ReadKey();
        }
    }
}
