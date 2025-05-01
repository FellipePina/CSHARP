using System;

namespace atividade_avaliativa_1
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe um numero para saber seu fatorial:");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Valores abaixo de 0 não são válidos.");
                Environment.Exit(0);
            }

            if (num == 0)
            {
                Console.WriteLine("Fatorial de !0: 1");
                Environment.Exit(0);
            }

            int fatorial = num;

            for (int i = fatorial - 1; i > 0; i--)
            {

                fatorial *= i;
            }

            Console.WriteLine("Fatorial de !" + num + ":" + fatorial);
        }
    }
}