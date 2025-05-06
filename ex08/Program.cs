using System;
using System.Globalization;
    class Program{
        static void Main(string[] args){

            CultureInfo formato = CultureInfo.InvariantCulture;

            Console.Write("Informe seu peso(KG):");
            float peso = 0;
            bool valido = float.TryParse(Console.ReadLine(),formato,out peso);

            while(!valido){
                Console.Write("Valor inválido, tente novamente:");
                valido = float.TryParse(Console.ReadLine(),formato,out peso);
            }

            Console.Write("Informe sua altura(m):");
            float altura= 0;
            valido = float.TryParse(Console.ReadLine(),formato, out altura);

            while(!valido){
                Console.Write("Valor inválido, tente novamente:");
                valido = float.TryParse(Console.ReadLine(),formato,out altura);
            }

            float imc = peso / (altura * altura);

            Console.WriteLine("Sua classificação:");
            Console.Write(imc.ToString("F2",formato) + " - ");

            if(imc < 18.5f){
                Console.WriteLine("Abaixo do peso");
            }
            else if(imc <= 24.9f){
                Console.WriteLine("Peso normal");
            }
            else if(imc <= 29.9f){
                Console.WriteLine("Sobrepeso");
            }
            else{
                Console.WriteLine("Obesidade");
            }
        }
    }
