using System;
using System.Globalization;
    class Program
    {
        static void Main(string[] args)
        {

            List<Produto> produtos = new List<Produto>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Cadastro de produtos:");
                Console.Write("Informe o nome do produto:");
                string nome = Console.ReadLine();

                Console.Write("Informe o preco do produto:");
                float preco = 0;
                bool valido = float.TryParse(Console.ReadLine(),CultureInfo.InvariantCulture, out preco);

                if(!valido){
                    Console.WriteLine("Valor do preco inválido.Tente novamente.");
                    valido = float.TryParse(Console.ReadLine(),CultureInfo.InvariantCulture, out preco);
                }

                Console.Write("Informe a quantidade do produto:");
                int quantidade = 0;
                valido = int.TryParse(Console.ReadLine(),out quantidade);

                if(!valido){
                    Console.WriteLine("Valor da quantidade inválido.Tente novamente.");
                    valido = int.TryParse(Console.ReadLine(),CultureInfo.InvariantCulture, out quantidade);
                }

                Produto p = new Produto(nome,preco,quantidade);
                produtos.Add(p);
            }

            Produto.ExibirDetalhes(produtos);
        }
    }
    class Produto
    {
        public string nome { get; set; }
        public float preco { get; set; }
        public int quantidade { get; set; }

        public Produto(string nome, float preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public static void ExibirDetalhes(List<Produto>produtos){

            CultureInfo formato = CultureInfo.InvariantCulture;

            foreach(Produto p in produtos){
                Console.WriteLine("Nome:" + p.nome);
                Console.WriteLine("Preco:" + p.preco.ToString("F2",formato));
                Console.WriteLine("Quantidade:" + p.quantidade);
                Console.WriteLine("Valor total em estoque: " + (p.quantidade * p.preco).ToString("F2",formato));
                Console.WriteLine();
            }
        }
    }

