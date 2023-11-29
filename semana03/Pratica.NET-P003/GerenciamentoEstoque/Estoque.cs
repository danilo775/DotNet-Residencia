using System;
using System.Collections.Generic;
using System.Linq;

namespace GerenciamentoEstoque
{
    public class Estoque
    {
        private List<Produto> produtos;

        public Estoque()
        {
            produtos = new List<Produto>();
        }

     
        public void CadastrarProduto(int codigo, string nome, int quantidade, decimal precoUnitario)
        {
            
            if (produtos.Any(p => p.Codigo == codigo))
            {
                throw new Exception("Produto com esse código já cadastrado.");
            }

        
            Produto produto = new Produto
            {
                Codigo = codigo,
                Nome = nome,
                Quantidade = quantidade,
                PrecoUnitario = precoUnitario
            };

            produtos.Add(produto);
        }

       
        public Produto BuscarProduto(int codigo)
        {
            Produto produto = produtos.FirstOrDefault(p => p.Codigo == codigo);

            if (produto == null)
            {
                throw new Exception("Produto não encontrado.");
            }

            return produto;
        }

     
        public void AtualizarEstoque(int codigo, int quantidade)
        {
            Produto produto = BuscarProduto(codigo);

      
            if (quantidade > produto.Quantidade)
            {
                throw new Exception("Quantidade insuficiente em estoque.");
            }

            produto.Quantidade += quantidade;
        }
        public void GerarRelatorios(int limiteEstoque, decimal minValor, decimal maxValor)
        {
        
            var produtosAbaixoLimite = produtos.Where(p => p.Quantidade < limiteEstoque).ToList();


            var produtosEntreValores = produtos.Where(p => p.PrecoUnitario >= minValor && p.PrecoUnitario <= maxValor).ToList();

      
            decimal valorTotalEstoque = produtos.Sum(p => p.Quantidade * p.PrecoUnitario);

            var valorTotalPorProduto = produtos.ToDictionary(p => p.Nome, p => p.Quantidade * p.PrecoUnitario);

            Console.WriteLine("Lista de produtos com quantidade em estoque abaixo do limite informado:");
            foreach (var produto in produtosAbaixoLimite)
            {
                Console.WriteLine($"{produto.Codigo} - {produto.Nome}");
            }

            Console.WriteLine("\nLista de produtos com valor entre o mínimo e o máximo informados:");
            foreach (var produto in produtosEntreValores)
            {
                Console.WriteLine($"{produto.Codigo} - {produto.Nome}");
            }

            Console.WriteLine($"\nValor total do estoque: {valorTotalEstoque}");

            Console.WriteLine("\nValor total de cada produto de acordo com seu estoque:");
            foreach (var produto in valorTotalPorProduto)
            {
                Console.WriteLine($"{produto.Key} - {produto.Value}");
            }
        }
        
    }
}