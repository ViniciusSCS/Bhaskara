using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            //fazendo a formula de bhaskara
            double a, b, c, x1, x2, delta;
            string calculaBhaskara;

            Console.Write("Qual valor de a? ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Qual valor de b? " );
            b = int.Parse(Console.ReadLine());
            Console.Write("Qual valor de c? " );
            c = int.Parse(Console.ReadLine());

            calculaBhaskara = CalculaBhaskara(a, b, c);

            Console.Write(calculaBhaskara);


        }

        static string CalculaBhaskara(double a, double b, double c)
        {
            double x1, x2, delta;
            string result;
            
            delta = Math.Pow(b, 2) - 4 * a * c;

            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            result = $"O valor positivo é {x1} e o negativo é {x2}";

            return result;
        }
    }
}