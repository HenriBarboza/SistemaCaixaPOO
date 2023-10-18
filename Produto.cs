using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    public class Produto
    {
        private long codigo;
        private string nome;
        private double preco;
        private int estoque;

        public Produto CadastrarProdutos()
        {
            System.Console.WriteLine("");
            System.Console.Write("Digite o código: ");
            this.codigo = Convert.ToInt64(Console.ReadLine());
            System.Console.Write("Digite o nome: ");
            this.nome = Console.ReadLine();
            System.Console.Write("Digite o estoque: ");
            this.estoque = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Digite o preco: ");
            this.preco = Convert.ToDouble(Console.ReadLine());
            return this; // retorna o objeto com conteúdo após a digitação

        }

        public void ExibirEstoque()
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("*******************************************************************");
            System.Console.WriteLine("*******************************************************************");
            System.Console.WriteLine("*************************  ESTOQUE  *******************************");
            System.Console.WriteLine($"\t\t CÓDIGO: {Codigo}");
            System.Console.WriteLine($"\t\t NOME: {Nome}");
            System.Console.WriteLine($"\t\t ESTOQUE: {Estoque}");
            System.Console.WriteLine($"\t\t PREÇO: R${Preco}");
            System.Console.WriteLine("*******************************************************************");
            System.Console.WriteLine("*******************************************************************");
        }

        public int Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public long Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

    }
}