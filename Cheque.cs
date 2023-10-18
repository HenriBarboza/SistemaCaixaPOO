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
        
    }
}