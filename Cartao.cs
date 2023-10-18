using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    public class Cartao :Pagamento
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
        
    }
}