using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    public class Cartao : Pagamento
    {
        private string dadosTransacao;
        private int resultadotransacao;
        
        public int ResultadoTransacao
        {
            get { return resultadotransacao; }
            set { resultadotransacao = value; }
        }
        
        public string DadosTransacao
        {
            get { return dadosTransacao; }
            set { dadosTransacao = value; }
        }
        public Cartao(double totalvenda, DateTime dataPagamento, string dados, int numeroTransação) : base(totalvenda, dataPagamento)
        {
            this.DadosTransacao = dados + $" Valor da compra: R${totalvenda} data:{dataPagamento}";
            this.ResultadoTransacao = numeroTransação;
        }
            public override void ExibirDados(){
            System.Console.WriteLine("****************************");
            System.Console.WriteLine("*****Dados do pagamento*****");
            System.Console.WriteLine("***** Método: Cartão ******");
            System.Console.WriteLine($"** {DadosTransacao} *");
            System.Console.WriteLine($"** Número de transação: {ResultadoTransacao} *");
            System.Console.WriteLine("****************************");
        }
    }
}