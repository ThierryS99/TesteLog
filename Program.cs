using Microsoft.VisualBasic;
using Serilog;
using System;

class Program
{
    static void Main(string[] args)
    {
        var logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.File("C:\\Dev\\TesteLog\\logs\\arquivoLog.txt")
            .CreateLogger();

        /*
        var logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Console()
            .WriteTo.File("C:\\Dev\\TesteLog\\logs\\arquivoLog.txt")
            .CreateLogger();
        */

        try
        {
            logger.Information("Entrou no menu.");
            while (true)
            {
                ExibirMenu();
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        ListarTarefas(); ; logger.Information("Opção 1. Listar tarefas");
                        break;
                    case "2":
                        AdicionarTarefa(); ; logger.Information("Opção 2. Adicionar tarefa");
                        break;
                    case "3":
                        ConcluirTarefa(); logger.Information("Opção 3. Concluir tarefa");
                        break;
                    case "4":
                        Console.WriteLine("Encerrando a aplicação..."); logger.Information("Opção 4. Sair");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente."); logger.Information("Opção inválida.");
                        break;
                }

                Console.WriteLine();
            }
        }

        catch
        {
            logger.Information("Não entrou no menu.");
        } 
    }

    static void ExibirMenu()
    {
        Console.WriteLine("======= Gerenciador de Tarefas =======");
        Console.WriteLine("1. Listar tarefas");
        Console.WriteLine("2. Adicionar tarefa");
        Console.WriteLine("3. Concluir tarefa");
        Console.WriteLine("4. Sair");
        Console.Write("Selecione uma opção: ");
    }

    static void ListarTarefas()
    {
        Console.WriteLine("=== Lista de Tarefas ===");
        // Lógica para listar as tarefas armazenadas
    }

    static void AdicionarTarefa()
    {
        Console.Write("Digite a descrição da tarefa: ");
        string tarefa = Console.ReadLine();
        // Lógica para adicionar a tarefa à lista de tarefas
    }

    static void ConcluirTarefa()
    {
        Console.Write("Digite o número da tarefa a ser concluída: ");
        int numero = int.Parse(Console.ReadLine());
        // Lógica para marcar a tarefa como concluída
    }

}
