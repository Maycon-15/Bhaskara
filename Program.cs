using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Double A, B, C, Delta, X1, X2;

            Console.WriteLine("-----BHASKARA-----");
            
            Console.WriteLine();

            Console.WriteLine("Formula: x = -b ± √b² - 4*a*c /2");

            Console.WriteLine();

            Console.WriteLine("Por favor, digite abaixo os numeros que serão usados no lugar das letras A, B e c:");

            Console.WriteLine();

            Console.Write("A:");
            A = Convert.ToDouble(Console.ReadLine());

            Console.Write("B:");
            B = Convert.ToDouble(Console.ReadLine());

            Console.Write("C:");
            C = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Primeiro teremos que achar o Delta (∆) com a seguinte formula: ∆ = b² - 4ac");

            Delta = (Math.Pow(B, 2)) - (4* A * C);

            Console.WriteLine();

            Console.WriteLine($"Delta é: {Delta}");

            Console.WriteLine();

            X1 = (-B + Math.Sqrt(Delta)) / (2*A);
            X2 = (-B - Math.Sqrt(Delta)) / (2*A);

            if (A == 0){
                Console.WriteLine("Não é uma equação de segundo grau!!");
            }

            else if (Delta < 0){
                Console.WriteLine($"Como Delta é = {Delta} a equação não possui raízes reais");
            }
            else
            {
                Console.WriteLine("-----Resultados-----");
                Console.WriteLine($"X1 = {X1:N2} e X2 = {X2:N2}");
            }
            Console.ReadKey();


        }
    }
}
