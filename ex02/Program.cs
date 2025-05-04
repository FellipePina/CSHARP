using System;
    class Program{
        static void Main(string[] args){

            Console.Write("Informe um número para ver sua tabuada de 1 a 10:");
            int num = 0;
            bool valido = int.TryParse(Console.ReadLine(), out num);

            if(!valido){
                Console.WriteLine("Valor inválido");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Tabuada do numero [" + num + "]");

            for(int i = 1; i < 11; i++){
                Console.WriteLine(num + "x" + i + "= " + (num * i));
            }
        }
    }
