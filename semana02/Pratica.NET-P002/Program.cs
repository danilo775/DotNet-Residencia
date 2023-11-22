using System;

namespace MeuProjeto
{
    public class Program
    {
        static void Main(string[] args)
        {
            GerenciadorTarefas gerenciador = new GerenciadorTarefas();

            bool executando = true;
            while (executando)
            {
                Console.Clear();
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1. Criar uma nova tarefa");
                Console.WriteLine("2. Listar todas as tarefas");
                Console.WriteLine("3. Marcar uma tarefa como concluída");
                Console.WriteLine("4. Listar tarefas pendentes");
                Console.WriteLine("5. Listar tarefas concluídas");
                Console.WriteLine("6. Excluir uma tarefa");
                Console.WriteLine("7. Pesquisar tarefas por palavra-chave");
                Console.WriteLine("8. Ver estatísticas");
                Console.WriteLine("0. Sair do programa");
                Console.WriteLine("================");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o título da tarefa: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Digite a descrição da tarefa: ");
                        string descricao = Console.ReadLine();
                        Console.Write("Digite a data de vencimento da tarefa (DD/MM/AAAA): ");
                        string inputDate = Console.ReadLine();
                        if (inputDate != null && DateTime.TryParse(inputDate, out DateTime dataVencimento))
                        {
                            gerenciador.CriarTarefa(titulo, descricao, dataVencimento);
                            Console.WriteLine("Tarefa criada com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Data inválida. Tarefa não foi criada.");
                        }

                        break;
                    case "2":
                        var tarefas = gerenciador.ListarTarefas();
                        Console.WriteLine("===== LISTA DE TAREFAS =====");
                        foreach (var tarefa in tarefas)
                        {
                            Console.WriteLine($"Título: {tarefa.Titulo}");
                            Console.WriteLine($"Descrição: {tarefa.Descricao}");
                            Console.WriteLine($"Data de vencimento: {tarefa.DataVencimento.ToShortDateString()}");
                            Console.WriteLine($"Concluída: {(tarefa.Concluida ? "Sim" : "Não")}");
                            Console.WriteLine("============================");
                        }
                        break;
                    case "3":
                        Console.Write("Digite o título da tarefa que deseja marcar como concluída: ");
                        string tituloTarefaConcluida = Console.ReadLine();
                        var tarefaConcluida = gerenciador.ListarTarefas().Find(t => t.Titulo == tituloTarefaConcluida);
                        if (tarefaConcluida != null)
                        {
                            gerenciador.MarcarTarefaComoConcluida(tarefaConcluida);
                            Console.WriteLine("Tarefa marcada como concluída!");
                        }
                        else
                        {
                            Console.WriteLine("Tarefa não encontrada.");
                        }
                        break;
                    case "4":
                        var tarefasPendentes = gerenciador.ListarTarefasPendentes();
                        Console.WriteLine("===== TAREFAS PENDENTES =====");
                        foreach (var tarefa in tarefasPendentes)
                        {
                            Console.WriteLine($"Título: {tarefa.Titulo}");
                            Console.WriteLine($"Descrição: {tarefa.Descricao}");
                            Console.WriteLine($"Data de vencimento: {tarefa.DataVencimento.ToShortDateString()}");
                            Console.WriteLine("=============================");
                        }
                        break;
                    case "5":
                        var tarefasConcluidas = gerenciador.ListarTarefasConcluidas();
                        Console.WriteLine("===== TAREFAS CONCLUÍDAS =====");
                        foreach (var tarefa in tarefasConcluidas)
                        {
                            Console.WriteLine($"Título: {tarefa.Titulo}");
                            Console.WriteLine($"Descrição: {tarefa.Descricao}");
                            Console.WriteLine($"Data de vencimento: {tarefa.DataVencimento.ToShortDateString()}");
                            Console.WriteLine("==============================");
                        }
                        break;
                    case "6":
                        Console.Write("Digite o título da tarefa que deseja excluir: ");
                        string tituloTarefaExcluir = Console.ReadLine();
                        var tarefaExcluir = gerenciador.ListarTarefas().Find(t => t.Titulo == tituloTarefaExcluir);
                        if (tarefaExcluir != null)
                        {
                            gerenciador.ExcluirTarefa(tarefaExcluir);
                            Console.WriteLine("Tarefa excluída com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Tarefa não encontrada.");
                        }
                        break;
                    case "7":
                    Console.Write("Digite uma palavra-chave para pesquisar tarefas: ");
                    string palavraChave = Console.ReadLine();

                    if (palavraChave != null)
                    {
                        var tarefasEncontradas = gerenciador.PesquisarTarefas(palavraChave);
                        Console.WriteLine("===== TAREFAS ENCONTRADAS =====");
                        foreach (var tarefa in tarefasEncontradas)
                        {
                            Console.WriteLine($"Título: {tarefa.Titulo}");
                            Console.WriteLine($"Descrição: {tarefa.Descricao}");
                            Console.WriteLine($"Data de vencimento: {tarefa.DataVencimento.ToShortDateString()}");
                            Console.WriteLine($"Concluída: {(tarefa.Concluida ? "Sim" : "Não")}");
                            Console.WriteLine("===============================");
                        }
                      }
                    else
                    {
                        Console.WriteLine("Palavra-chave inválida. A pesquisa não foi realizada.");
                    }  
                        break;
                    case "8":
                        Console.WriteLine("===== ESTATÍSTICAS =====");
                        Console.WriteLine($"Número de tarefas concluídas: {gerenciador.NumeroTarefasConcluidas()}");
                        Console.WriteLine($"Número de tarefas pendentes: {gerenciador.NumeroTarefasPendentes()}");
                        var tarefaMaisAntiga = gerenciador.TarefaMaisAntiga();
                        var tarefaMaisRecente = gerenciador.TarefaMaisRecente();
                        Console.WriteLine($"Tarefa mais antiga: {(tarefaMaisAntiga != null ? tarefaMaisAntiga.Titulo : "Nenhuma")}");
                        Console.WriteLine($"Tarefa mais recente: {(tarefaMaisRecente != null ? tarefaMaisRecente.Titulo : "Nenhuma")}");
                        Console.WriteLine("=======================");
                        break;
                    case "0":
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha novamente.");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}