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
      public Especie(double totalvenda, DateTime dataPagamento, double quantia) : base(totalvenda, dataPagamento)
      {
         this.Quantia = quantia;
         this.Troco = quantia - totalvenda;
      }
         public override void ExibirDados(){
            System.Console.WriteLine("****************************");
            System.Console.WriteLine("*****Dados do pagamento*****");
            System.Console.WriteLine("***** Método: Espécie ******");
            System.Console.WriteLine($"***** Total: {Quantia - Troco}  ******");
            System.Console.WriteLine($"***** Quantia: {Quantia}  ******");
            System.Console.WriteLine($"***** Troco: {Troco}  ******");
            System.Console.WriteLine("****************************");
        }
   }
}