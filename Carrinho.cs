using System;
using System.Collections.Generic;

namespace Exercicio
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> minicart = new List<Produto>();

        public void Adicionar(Produto _produto)
        {
            minicart.Add(_produto);
        }

        public void Remover(Produto _produto)
        {
            minicart.Remove(_produto);
        }

        public void MostrarCarrinho(){

            foreach(Produto p in minicart)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{p.Nome} - R$ {p.Preco}");
                Console.ResetColor();
            }

            if( minicart != null )
            {
                foreach( Produto p in minicart )
                {
                    ValorTotal += p.Preco;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Valor total: R$ {ValorTotal} ");
                Console.ResetColor();
            }else
            {
                Console.WriteLine($"O carrinho está vazio!");
            }

            }   

        public void ProcurarProduto(Produto _produto){

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Digite o código do produto. ");
            int _cod = Int32.Parse(Console.ReadLine());

            Produto procurar = minicart.Find( x => x.Codigo == _cod);
            Console.WriteLine($"Nome do Produto: {procurar.Nome}");

            Console.ResetColor();
        }

        public void AlterarProduto( int _codigo, Produto _produtoAlterado ){
            
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            minicart.Find( z => z.Codigo == _codigo).Nome = _produtoAlterado.Nome;
            minicart.Find( z => z.Codigo == _codigo).Preco = _produtoAlterado.Preco;

            Console.ResetColor();
        }
    }
}