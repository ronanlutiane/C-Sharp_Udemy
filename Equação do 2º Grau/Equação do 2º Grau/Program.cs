using System;

namespace Equação_do_2º_Grau
{
    class Program
    {
        static void Main(string[] args)

        //Este codigo recebe os valores de A, B e C no input do usuário e calcula as raizes da Equação 
        //do segundo grau baseado neste input
        {
            Console.WriteLine("Informe o valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de C: ");
            int c = int.Parse(Console.ReadLine());
            double delta = (b * b) - 4 * (a * c);
            if (delta == 0)
            {
                double raiz = -b / (2 * a);
                Console.WriteLine("Delta igual a 0, esta equação possui apenas uma raíz real: " + raiz);
            }
            else if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Esta equação possui duas raízes reais: X1 = " + x1 + " e X2 = " + x2);
            }
            else
            {
                Console.WriteLine("Delta menor que 0, portanto esta equação não possui raízes reais.");
            }
        }
    }
}
