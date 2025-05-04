using System;
using System.Text.RegularExpressions;
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Digite sua senha:");
            string Senha = Console.ReadLine();

            bool TamanhoSenha = Senha.Length >= 8;
            bool LetraMaiuscula = Regex.IsMatch(Senha, @"[A-Z]");
            bool ContemNumero = Regex.IsMatch(Senha, @"[0-9]");
            //bool CaracterEspecial = Regex.IsMatch(Senha, @"[!@#$%^&*]");
            bool CaracterEspecial = Regex.IsMatch(Senha,@"[!@#$%^&*()_+\-=\?/\\]");

            if (TamanhoSenha && LetraMaiuscula && ContemNumero && CaracterEspecial)
            {
                Console.WriteLine("Senha válida!");
            }
            else
            {
                Console.WriteLine("Senha inválida. Reveja o(s) seguinte(s) critério(s):");

                if (!TamanhoSenha)
                {
                    Console.WriteLine("A senha deve conter pelo menos 8 caracteres");
                }
                if (!LetraMaiuscula)
                {
                    Console.WriteLine("A senha deve conter pelo menos 1 letra maiúscula");
                }
                if (!ContemNumero)
                {
                    Console.WriteLine("A senha deve conter pelo menos 1 número");
                }
                if (!CaracterEspecial)
                {
                    Console.WriteLine("A senha deve conter pelo menos 1 caracter especial");
                }
            }
        }
    }

