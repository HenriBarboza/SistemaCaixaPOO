using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    public class Pagamento
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
    }
}