using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    public abstract class Pagamento
    {
        protected DateTime data;
        protected double total;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public Pagamento(double totalvenda, DateTime dataPagamento)
        {
            this.Data = dataPagamento;
            this.Total = totalvenda;
        }
        public abstract void ExibirDados();
    }
}