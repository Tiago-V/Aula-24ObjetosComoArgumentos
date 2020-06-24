using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Produtos 

            Produto p1 = new Produto(1, "Produto 1", 1);
            Produto p2 = new Produto(2, "Produto 2", 2);
            Produto p3 = new Produto(3, "Produto 3", 3);
            Produto p4 = new Produto(4, "Produto 4", 4);
            Produto p5 = new Produto(5, "Produto 5", 5);

            // Instanciar Carrinho

            Carrinho minicart = new Carrinho();

            // Adicionar a Lista do Carrinho

            minicart.Adicionar(p1);
            minicart.Adicionar(p2);
            minicart.Adicionar(p3);
            minicart.Adicionar(p4);
            minicart.Adicionar(p5);

            // Remover Produto

            minicart.Remover(p4);

            // Alterar Produto
            Produto p6 = new Produto(1, "Produto 6", 6 );
            
            minicart.AlterarProduto(1, p6);

            // Mostrar Carrinho

            Console.WriteLine("Carrinho:");
            Console.WriteLine();
            minicart.MostrarCarrinho();

            // Procurar Produto

            minicart.ProcurarProduto(p1);


            
        }
    }
}
