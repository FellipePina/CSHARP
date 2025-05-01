using System;
using System.Collections.Generic;

namespace atividade_avaliativa_1
{

    class Program
    {
        static void Main(string[] args)
        {

            List<string> tarefas = new List<string>();

            bool executar = true;

            Console.WriteLine("Escolha uma das opções abaixo:");
            while (executar)
            {
                Console.WriteLine("1- Adicionar tarefa\n2- Marcar tarefa como concluida\n3-sair");
                Console.Write("Escolha:");
                int escolha = int.Parse(Console.ReadLine());

                while (escolha < 1 || escolha > 3)
                {
                    Console.WriteLine("Valor inválido.Tente novamente!");
                    Console.Write("Escolha:");
                    escolha = int.Parse(Console.ReadLine());
                }

                switch (escolha)
                {

                    case 1:
                        Console.Write("Infome uma nova tarefa:");
                        string novaTarefa = Console.ReadLine();
                        tarefas.Add(novaTarefa);
                        Console.WriteLine("Tarefa adicionada com sucesso!\n");
                        break;

                    case 2:

                        if (tarefas.Count == 0)
                        {
                            Console.WriteLine("Nenhuma tarefa cadastrada.\n");
                        }
                        else
                        {
                            Console.WriteLine("Lista:");

                            for (int i = 0; i < tarefas.Count; i++)
                            {
                                Console.WriteLine((i + 1) + " - " + tarefas[i]);
                            }

                            Console.Write("Informe o numero da tarefa a ser marcada como concluida:");
                            int num = int.Parse(Console.ReadLine());

                            if (num >= 1 && num <= tarefas.Count)
                            {
                                tarefas[num - 1] = "[Concluida]" + tarefas[num - 1];
                                Console.WriteLine("Tarefa marcada com concluída.\n");
                            }
                            else
                            {
                                Console.WriteLine("Valor inválido\n");
                            }
                        }
                        break;

                    case 3:
                        executar = false;
                        Console.WriteLine("\nLista Final:");

                        for (int i = 0; i < tarefas.Count; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + tarefas[i]);
                        }
                        Console.WriteLine("\nEncerrando programa..");
                        break;
                }
            }
        }
    }
}
