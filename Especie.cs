using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    public class Especie : Pagamento
    {
     private double quantia;
     private double troco;
     public double Troco
     {
        get { return troco; }
        set { troco = value; }
     }
     
     public double Quantia
     {
        get { return quantia; }
        set { quantia = value; }
     }
        
    }
}