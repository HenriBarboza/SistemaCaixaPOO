using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    public class Cheque : Pagamento
    {
        private long numero;

        private DateTime dataDeposito;
        private int situacao;

        public int Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        public DateTime DataDeposito
        {
            get { return dataDeposito; }
            set { dataDeposito = value; }
        }


        public long Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public Cheque(double totalvenda, DateTime dataPagamento) : base(totalvenda, dataPagamento)
        {
        }

        public Pagamento InserirCheque()
        {
            Console.Write("Insira o número do cheque: ");
            this.Numero = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Insira a situação (1 - Compensado, 2 - Devolvido): ");
            this.Situacao = Convert.ToInt32(Console.ReadLine());
            this.DataDeposito = DateTime.Now;
            return this;
        }
        public override void ExibirDados()
        {
            System.Console.WriteLine("****************************");
            System.Console.WriteLine("*****Dados do pagamento*****");
            System.Console.WriteLine("***** Método: Cheque ******");
            System.Console.WriteLine($"** Número do cheque {Numero} *");
            System.Console.WriteLine($"** Data de depósito {DataDeposito} *");
            System.Console.WriteLine($"** Situaçao {situacao} *");
            System.Console.WriteLine("****************************");
        }
    }
}