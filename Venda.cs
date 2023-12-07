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


        public List<Pagamento> VetPagamento
        {
            get { return vetPagamento; }
            set { vetPagamento = value; }
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
        public Venda()
        {
            this.Data = DateTime.Now;
            this.VetItemVenda = new List<ItemVenda>();
            this.VetPagamento = new List<Pagamento>();
        }

        public void AdicionarItens(Produto prod, int quantidade)
        {
            this.VetItemVenda.Add(new ItemVenda(prod, quantidade));
            prod.AtualizarEstoque(quantidade);
        }
        public void RegistrarPagamento(Pagamento p)
        {
            VetPagamento.Add(p);
        }
        public void CalcularTotal()
        {
            // Inicializa o total como zero
            this.Total = 0;

            // Percorre a lista de itens de venda e soma os subtotais
            foreach (ItemVenda p in vetItemVenda)
            {
                this.Total += p.Subtotal;
            }
        }

        public void ResetarVenda()
        {
            this.Data = DateTime.Now;
            this.Total = 0;
            this.VetItemVenda.Clear(); // Limpa a lista de itens de venda
            this.VetPagamento.Clear(); // Limpa a lista de pagamentos
        }

        public void ExibirDados()
        {
            System.Console.WriteLine("*******************************************************************");
            System.Console.WriteLine("**************************  Venda  ********************************");
            System.Console.WriteLine($"**************** Data: {Data}   ***********************");
            foreach (ItemVenda p in vetItemVenda)
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("*******************************************************************");
                System.Console.WriteLine("*******************************************************************");
                System.Console.WriteLine("*************************  Produto  *******************************");
                System.Console.WriteLine($"\t\t CÓDIGO: {p.ObjProduto.Codigo}");
                System.Console.WriteLine($"\t\t NOME: {p.ObjProduto.Nome}");
                System.Console.WriteLine($"\t\t Quantidade: {p.Quantidade}");
                System.Console.WriteLine($"\t\t PREÇO: R${p.Preco}");
                System.Console.WriteLine($"\t\t Subtotal: R${p.Subtotal}");
                System.Console.WriteLine("*******************************************************************");
                System.Console.WriteLine("*******************************************************************");
            }
        System.Console.WriteLine($"Total da Venda: R${Total}");
        }
                public void ExibirDadosVetPagamento()
        {
            Console.WriteLine("Métodos de pagamento:");
            foreach (Pagamento pag in VetPagamento) 
            {
                pag.ExibirDados();
            }
        }
    }
}

/*  1- Faça os relacionamentos exestirem na composição e com a classe pagamento
    2- Implemente os encapsulamentos
    3- Implemente o método Exibir() de todas as classes
    4- Implementar os construtores com todos os parâmetros
    5- Instanciar objetos para testar
*/