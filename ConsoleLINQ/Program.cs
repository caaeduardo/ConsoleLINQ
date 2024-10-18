using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FONTE DE DADOS
            List<Produto> produtos = new List<Produto>
{
    new Produto { Id = 1, Nome = "Caderno", Status = true, Valor = 10, CategoriaId = 1 },
    new Produto { Id = 2, Nome = "Caneta",Status = true, Valor = 5, CategoriaId = 1 },
    new Produto { Id = 3, Nome = "Lápis", Status = true, Valor = 1, CategoriaId = 1 },
    new Produto { Id = 4, Nome = "Borracha", Status = true, Valor = 1, CategoriaId = 1 },
    new Produto { Id = 5, Nome = "Apontador", Status = true, Valor = 2, CategoriaId = 1 },
    new Produto { Id = 6, Nome = "Tesoura", Status = true, Valor = 7, CategoriaId = 1 },
    new Produto { Id = 7, Nome = "Grampeador", Status = true, Valor = 10, CategoriaId = 1 },
    new Produto { Id = 8, Nome = "Clips", Status = true, Valor = 1, CategoriaId = 1 },
    new Produto { Id = 9, Nome = "Cola", Status = true, Valor = 2, CategoriaId = 1 },
    new Produto { Id = 10, Nome = "Grampo",Status = true, Valor = 3, CategoriaId = 1 },
    new Produto { Id = 11, Nome = "Pão", Status = true, Valor = 4, CategoriaId = 2 },
    new Produto { Id = 12, Nome = "Café", Status = true, Valor = 5, CategoriaId = 2 },
            };

            List<Categoria> categorias = new List<Categoria>
            {
                new Categoria { Id = 1, Nome = "Papelaria" },
                new Categoria { Id = 2, Nome = "Padaria"} 
            };
            // CRIAR CONSULTA LINQ (CONSULTA)
            var resultado = from produto in produtos
                            where produto.Valor > 0
                            select produto;




            //EXECUTAR A CONSULTA

            //MOD Cadu ;)
            foreach (var result in resultado)
            Console.WriteLine($"{result.Id} - {result.Nome} - {result.Valor} - {result.CategoriaId}");


            //FORMA DE LINQ[] MOD.CARLOS EDUARDO CAVALLETTO(Vulgo Lobão) I
            //foreach (var produto in resultado)
            //Console.WriteLine(produto);


            //FORMA DE LINQ [] MOD.CARLOS EDUARDO CAVALLETTO (Vulgo Lobão) II
            //int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Array.ForEach(nums, n => Console.Write(n));


            //int soma = produtos.Aggregate(0, (total, produto) => total + produto.Valor);

            //Console.WriteLine("A soma é igual a " + soma);

            Console.ReadKey();
        
        
        
            
        }

        class Produto //Classe Produto
        {
            //Propriedades: int = inteiro; string = texto; bool = true ou false;
            //char: Um único caractere; decimal: Números decimais de alta precisão.

            public int Id { get; set; }
            public string Nome { get; set; }
            public bool Status { get; set; }
            public int Valor { get; set; }
            public int CategoriaId { get; set; }

            public override string ToString()
            {
                return $"{Id} - {Nome} - {Valor} - {CategoriaId}";
            }

        }
        class Categoria
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public bool status { get; set; }

        }

    }
}
