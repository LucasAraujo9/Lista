using System;
using System.Collections.Generic;
using System.Linq;


namespace TreinandoList
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            var listaProduto = new List<Produto>();
            // lista de produtos --^----^               
            var produto1 = new Produto();
            var produto2 = new Produto();
            var produto3 = new Produto();
            
            produto1.Nome = "AAAAA";
            produto1.CPF = 222222;

            produto2.Nome = "CCCCC";
            produto2.CPF = 111111;

            produto3.Nome = "BBBBBB";
            produto3.CPF = 333333;

            listaProduto.Add(produto1);
            listaProduto.Add(produto2);
            listaProduto.Add(produto3);

            Console.WriteLine("1 - ordenar por nome");
            Console.WriteLine("2 - ordenar por cpf");
            int x = int.Parse(Console.ReadLine());

            while (x != 1 && x != 2) // não sair enquanto não digitar uma opcao valida
            {
                Console.WriteLine("Digite novamente");
                Console.WriteLine("1 - ordenar por nome");
                Console.WriteLine("2 - ordenar por cpf");
                x = int.Parse(Console.ReadLine());
            }

            if (x == 1)
            {                                               // lambda para ordenar por nome
                var produtoOrdenados = listaProduto.OrderBy(conta => conta.Nome);
                         // produto em produtos ordenados
                foreach (var produto in produtoOrdenados)
                {                       //imprimir na tela 
                    Console.WriteLine($"Nome: {produto.Nome} - CPF: {produto.CPF}");
                }
            }
            if (x == 2)
            {                                               // lambda para ordenar por CPF
                var produtoOrdenados = listaProduto.OrderBy(conta => conta.CPF);
                         // produto em produtos ordenados
                foreach (var produto in produtoOrdenados)
                {                       //imprimir na tela 
                    Console.WriteLine($"Nome: {produto.Nome} - CPF: {produto.CPF}");
                }
            }

            Console.WriteLine("ORDENADO!");
            Console.ReadLine();
        }

        public class Produto // classe produto
        {
            public string Nome { get; set; }
            public int CPF { get; set; }
        }
    }
}
