using System;

namespace Área_do_Círculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o raio da circunferência");
            double raio = double.Parse(Console.ReadLine());
            double area = Math.PI * (raio * raio);
            Console.WriteLine("Área do círculo = " + Convert.ToString(area));
        }
    }
}
