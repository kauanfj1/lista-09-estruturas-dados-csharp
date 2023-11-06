using System;
using System.Collections;

class CarrinhoDeCompras
{
    static Hashtable carrinho = new Hashtable();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Bem-vindo ao Carrinho de Compras!");
            Console.WriteLine("1. Adicionar Produto");
            Console.WriteLine("2. Visualizar Carrinho");
            Console.WriteLine("3. Finalizar Compra");
            Console.WriteLine("4. Sair");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    AdicionarProduto();
                    break;
                case 2:
                    VisualizarCarrinho();
                    break;
                case 3:
                    FinalizarCompra();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void AdicionarProduto()
    {
        Console.Write("Nome do produto: ");
        string nome = Console.ReadLine();

        Console.Write("Preço do produto: ");
        decimal preco = decimal.Parse(Console.ReadLine());

        carrinho[nome] = preco;
        Console.WriteLine("Produto adicionado ao carrinho!");
    }

    static void VisualizarCarrinho()
    {
        Console.WriteLine("Produtos no carrinho:");

        if (carrinho.Count == 0)
        {
            Console.WriteLine("O carrinho está vazio.");
        }
        else
        {
            foreach (DictionaryEntry item in carrinho)
            {
                Console.WriteLine($"{item.Key}: R${item.Value}");
            }
        }
    }

    static void FinalizarCompra()
    {
        decimal valorTotal = 0;

        foreach (DictionaryEntry item in carrinho)
        {
            valorTotal += (decimal)item.Value;
        }

        Console.WriteLine($"Valor total a ser pago: R${valorTotal}");
        carrinho.Clear();
    }
}
