using System;

namespace atividade_avaliativa_1{

    class Program{

        static void Main(string[]args){

            Console.WriteLine("Informe 10 números inteiros:");
            int[] valores = new int[10];

            int somaPares = 0;
            for(int i = 0; i < 10; i++){
                Console.Write("Valor " + (i+1) + ":");
                valores[i] = int.Parse(Console.ReadLine());

                if(valores[i] % 2 == 0){
                    somaPares += valores[i];
                }
            }

            Console.WriteLine("Soma dos valores pares:" + somaPares);
        }
    }
}
