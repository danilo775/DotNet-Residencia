using System;

namespace GerenciamentoEstoque
{
    class Program
    {
        static Estoque estoque;

        static void Main(string[] args)
        {
            estoque = new Estoque();

            bool sair = false;

            while (!sair)
            {
                Console.WriteLine("----- MENU -----");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Consultar Produto");
                Console.WriteLine("3 - Atualizar Estoque");
                Console.WriteLine("4 - Gerar Relatórios");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("----------------");

                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        CadastrarProduto();
                        break;
                    case 2:
                        ConsultarProduto();
                        break;
                    case 3:
                        AtualizarEstoque();
                        break;
                    case 4:
                        GerarRelatorios();
                        break;
                    case 0:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void CadastrarProduto()
        {
            try
            {
                Console.Write("Digite o código do produto: ");
                int codigo = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();

                Console.Write("Digite a quantidade em estoque: ");
                int quantidade = int.Parse(Console.ReadLine());

                Console.Write("Digite o preço unitário do produto: ");
                decimal preco = decimal.Parse(Console.ReadLine());

                estoque.CadastrarProduto(codigo, nome, quantidade, preco);
                Console.WriteLine("Produto cadastrado com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar o produto: {ex.Message}");
            }
        }

        static void ConsultarProduto()
        {
            try
            {
                Console.Write("Digite o código do produto: ");
                int codigo = int.Parse(Console.ReadLine());

                Produto produto = estoque.BuscarProduto(codigo);
                Console.WriteLine($"Produto encontrado: {produto.Nome} - Quantidade: {produto.Quantidade} - Preço Unitário: {produto.PrecoUnitario}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao consultar o produto: {ex.Message}");
            }
        }

        static void AtualizarEstoque()
        {
            try
            {
                Console.Write("Digite o código do produto: ");
                int codigo = int.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade a ser adicionada (valor positivo) ou removida (valor negativo): ");
                int quantidade = int.Parse(Console.ReadLine());

                estoque.AtualizarEstoque(codigo, quantidade);
                Console.WriteLine("Estoque atualizado com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao atualizar o estoque: {ex.Message}");
            }
        }
        static void GerarRelatorios()
        {
            Console.Write("Digite o limite de quantidade em estoque para o relatório de produtos abaixo do limite: ");
            int limiteEstoque = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor mínimo para o relatório de produtos entre valores: ");
            decimal minValor = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o valor máximo para o relatório de produtos entre valores: ");
            decimal maxValor = decimal.Parse(Console.ReadLine());

            estoque.GerarRelatorios(limiteEstoque, minValor, maxValor);
        }

       
    }
}