using System;

namespace atividade_avaliativa_1{

    class Program{
        static void Main(string[] args){

            Console.WriteLine("Jogo da Adivinhação:");

            Random r = new Random();
            int numAleatorio = r.Next(1,101);
            
            bool acertou = false;
            int tentativas = 0, palpite = 0;

            while(acertou != true){

                tentativas ++;
                Console.Write("Tente acertar o valor:");

                palpite = int.Parse(Console.ReadLine());

                while(palpite < 1 || palpite > 100){
                    Console.WriteLine("Valor inválido. As tentativas devem ser entre 1 e 100:");
                    palpite = int.Parse(Console.ReadLine());
                }

                if(palpite < numAleatorio){
                    Console.WriteLine("O valor correto é maior");
                    Console.WriteLine();
                }
                else if(palpite > numAleatorio){
                    Console.WriteLine("O valor correto é menor");
                    Console.WriteLine();
                }
                else{
                    acertou = true;
                    Console.WriteLine("Parabéns, você acertou!!!");
                    Console.WriteLine("Número de tentativas:" + tentativas);
                }
            }
        }
    }
}
