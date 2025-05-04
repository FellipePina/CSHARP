using System;
using System.Globalization;
using System.Text;
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite uma palavra ou frase:");
            string texto = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(texto))
            {
                Console.WriteLine("Entrada inválida");
                return;
            }

            string TextoFinal = TratamentoTexto(texto.ToLower());

            char[] array = TextoFinal.ToCharArray();
            Array.Reverse(array);
            string TextoReverso = new string(array);

            if (TextoFinal == TextoReverso)
            {
                Console.WriteLine("É palíndromo!");
            }
            else
            {
                Console.WriteLine("Não é palíndromo.");
            }
        }
        static string TratamentoTexto(string texto)
        {

            texto = texto.Replace(" ", "");

            string TextoNormal = texto.Normalize(NormalizationForm.FormD);

            StringBuilder sb = new StringBuilder();

            foreach (char c in TextoNormal)
            {

                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {

                    sb.Append(c);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }
    }

