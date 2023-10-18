using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHerancaComposicaoVenda
{
    public class ItemVenda
    {
        private int quantidade;
        private double preco;
        private double subTotal;
        private Produto objProduto;
        
        // O ObjProduto é a associação estabelecida

        public Produto ObjProduto
        {
            get { return objProduto; }
            set { objProduto = value; }
        }
        

        public double Subtotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }
        
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        
    }
}