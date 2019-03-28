using System;

namespace Exercício2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero inteiro qualquer");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite um segundo inteiro qualquer");
            int num2 = int.Parse(Console.ReadLine());
            int soma = num1 + num2;
            Console.WriteLine("Soma = " + Convert.ToString(soma));
        }
    }
}
