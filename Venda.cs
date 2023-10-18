using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    public class Venda
    {
        private DateTime data;
        private double total;
        private List<ItemVenda> vetItemVenda;
        private List<Pagamento> vetPagamento;
        public List<Pagamento> VetPagamaneto
        {
            get { return vetPagamento; }
            set { vetPagamento = value; }
        }
        
        public Venda()
        {
          VetItemVenda = new List<ItemVenda>();   
          VetPagamaneto = new List<Pagamento>();
        }
        public List<ItemVenda> VetItemVenda
        {
            get { return vetItemVenda; }
            set { vetItemVenda = value; }
        }
        
        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        
    }
}

/*  1- Faça os relacionamentos exestirem na composição e com a classe pagamento
    2- Implemente os encapsulamentos
    3- Implemente o método Exibir() de todas as classes
    4- Implementar os construtores com todos os parâmetros
    5- Instanciar objetos para testar
*/