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
        public ItemVenda(Produto objetoProduto,int qntd)
        {
            this.ObjProduto = objetoProduto;
            this.Quantidade = qntd;
            this.Preco = ObjProduto.Preco;
            this.Subtotal = VerficarDesconto();
        }
        public double VerficarDesconto(){
            if(this.Quantidade >= 50){
                return (Preco * Quantidade) * 0.9;
            }
            else{
                return Preco * Quantidade;;
            }
        }
    }
}