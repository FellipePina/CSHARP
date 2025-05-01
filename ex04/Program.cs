using System;
using System.Globalization;

namespace atividade_avaliativa_1
{
    class Program
    {
        static readonly CultureInfo formato = CultureInfo.InvariantCulture;
        static void Main(string[] args)
        {

            int Escolha = 1;

            while (Escolha != 3)
            {
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("1 - Celsius para Fahrenheit\n2 - Fahrenheit para Celsius\n3 - Sair");
                Console.Write("Escolha:");
                Escolha = int.Parse(Console.ReadLine());

                while (Escolha < 1 || Escolha > 3)
                {
                    Console.Write("Valor inválido.Tente novamente:");
                    Escolha = int.Parse(Console.ReadLine());
                }

                switch (Escolha)
                {

                    case 1:
                        Console.WriteLine();
                        Console.Write("Informe um valor em Celsius:");
                        float Celsius = float.Parse(Console.ReadLine(),formato);
                        ConversaoCelsius(Celsius);
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.Write("Informe um valor em Fahrenheit:");
                        float Fahrenheit = float.Parse(Console.ReadLine(),formato);
                        ConversaoFahrenheit(Fahrenheit);
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Fim da execução!");
                        break;
                }
            }
        }
        static void ConversaoCelsius(float Celsius)
        {
            float Fahrenheit = 1.8f * Celsius + 32;
            Console.WriteLine("Valor convertido para Fahrenheit: " + Fahrenheit.ToString("F2",formato));
        }
        static void ConversaoFahrenheit(float Fahrenheit)
        {
            float Celsius = (Fahrenheit - 32) / 1.8f;
            Console.WriteLine("Valor convertido para Celsius: " + Celsius.ToString("F2",formato));
        }
    }
}
