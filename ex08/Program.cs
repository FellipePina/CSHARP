using System;
using System.Globalization;

namespace atividade_avaliativa_1{

    class Program{
        static void Main(string[] args){

            CultureInfo formato = CultureInfo.InvariantCulture;

            Console.Write("Informe seu peso(KG):");
            float peso = float.Parse(Console.ReadLine(),formato);

            Console.Write("Informe sua altura(m):");
            float altura= float.Parse(Console.ReadLine(),formato);

            float imc = peso / (altura * altura);

            Console.WriteLine("Sua classificação:");
            Console.Write(imc.ToString("F2",formato) + " - ");

            if(imc < 18.5f){
                Console.WriteLine("Abaixo do peso");
            }
            else if(imc < 24.9f){
                Console.WriteLine("Peso normal");
            }
            else if(imc < 29.9f){
                Console.WriteLine("Sobrepeso");
            }
            else{
                Console.WriteLine("Obesidade");
            }
        }
    }
}
