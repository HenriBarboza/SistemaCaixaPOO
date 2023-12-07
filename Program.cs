using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using TrabalhoHerancaComposicaoVenda;

// Produto p1 = new Produto();
// p1.CadastrarProudtos();
// Produto p2 = new Produto();
// p2.CadastrarProudtos();
int op = 0;
int posicaoAtual = 0;
Produto[] produtos = null;
Venda novaVenda = new Venda();
while (op != 6)
{
    System.Console.WriteLine("");
    System.Console.WriteLine("*******************************************************************");
    System.Console.WriteLine("*******************************************************************");
    System.Console.WriteLine("****************************  MENU  *******************************");
    System.Console.WriteLine("******************* 1 - INSERIR PRODUTO(S)  ***********************");
    System.Console.WriteLine("******************* 2 - EXIBIR PRODUTO(S)   ***********************");
    System.Console.WriteLine("******************* 3 - REALIZAR VENDA      ***********************");
    System.Console.WriteLine("******************* 4 - REALIZAR PAGAMENTO  ***********************");
    System.Console.WriteLine("******************* 5 - EXIBIR ULTIMA VENDA ***********************");
    System.Console.WriteLine("******************* 6 - ENCERRAR SISTEMA    ***********************");
    System.Console.WriteLine("*******************************************************************");
    System.Console.WriteLine("*******************************************************************");
    System.Console.WriteLine("");
    System.Console.Write("Insira a opção desejada: ");

    op = Convert.ToInt32(Console.ReadLine());
    switch (op)
    {
        case 1:

            Console.Write("Insira a quantidade de produtos que deseja inserir: ");
            int qnt = Convert.ToInt32(Console.ReadLine());

            if (produtos == null)
            {
                produtos = new Produto[qnt];
            }
            else
            {
                // Verifique se há espaço suficiente no array para a quantidade inserida
                if (posicaoAtual + qnt > produtos.Length)
                {
                    // Redimensione o array se não houver espaço suficiente
                    Array.Resize(ref produtos, produtos.Length + qnt);
                }
            }

            for (int i = 0; i < qnt; i++)
            {
                produtos[posicaoAtual] = new Produto();
                produtos[posicaoAtual].CadastrarProdutos();
                posicaoAtual++; // Atualize a posição atual no array
            }
            break;
        case 2:
            if (produtos != null)
            {
                System.Console.WriteLine("Digite 1 para listar todos os produtos, 2 para mostrar dados apenas de um produto ou 3 para voltar: ");
                int op1 = Convert.ToInt32(Console.ReadLine());
                switch (op1)
                {
                    case 1:
                        for (int i = 0; i < posicaoAtual; i++)
                        {
                            produtos[i].ExibirEstoque();
                        }
                        break;
                    case 2:
                        System.Console.WriteLine("Digite o código do produto que deseja buscar: ");
                        int cod = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < posicaoAtual; i++)
                        {
                            produtos[i].LocalizarProduto(cod);
                        }
                        break;
                }

            }
            else
            {
                Console.WriteLine("Nenhum produto cadastrado.");
            }
            break;
        case 3:
            if (produtos != null && posicaoAtual > 0)
            {
                novaVenda.ResetarVenda();
                // Adicione produtos à venda
                Console.Write("Digite a quantidade de produtos que deseja adicionar à venda: ");
                int quantidadeProdutos = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < quantidadeProdutos; i++)
                {
                    Console.Write($"Digite o código do produto {i + 1}: ");
                    int codigoProduto = Convert.ToInt32(Console.ReadLine());

                    Produto produtoSelecionado = null;

                    // Busque o produto no array
                    for (int j = 0; j < posicaoAtual; j++)
                    {
                        if (produtos[j].Codigo == codigoProduto)
                        {
                            produtoSelecionado = produtos[j];
                        }
                    }

                    if (produtoSelecionado != null)
                    {
                        Console.Write($"Digite a quantidade do produto {produtoSelecionado.Nome}: ");
                        int quantidade = Convert.ToInt32(Console.ReadLine());

                        novaVenda.AdicionarItens(produtoSelecionado, quantidade);
                    }
                    else
                    {
                        Console.WriteLine("Código de produto inválido. A venda será cancelada.");
                    }
                }
                novaVenda.CalcularTotal();
                // Exiba os itens da venda
                novaVenda.ExibirDados();
            }
            break;
        case 4:
            System.Console.WriteLine("******* Menu Pagamento ******");
            System.Console.WriteLine("*****************************");
            System.Console.WriteLine("******* 1 - Espécie *********");
            System.Console.WriteLine("******* 2 - Cartão **********");
            System.Console.WriteLine("******* 3 - Cheque **********");
            System.Console.WriteLine("******* 4 - Sair ************");
            System.Console.WriteLine("*****************************");
            int op2 = Convert.ToInt32(Console.ReadLine());
            switch (op2)
            {
                case 1:
                    System.Console.WriteLine("Insira o valor do pagamento: ");
                    double valorPag = Convert.ToInt32(Console.ReadLine());
                    DateTime dataPag = DateTime.Now;
                    if (valorPag >= novaVenda.Total)
                    {
                        Especie pagEspecie = new Especie(novaVenda.Total, dataPag, valorPag);
                        novaVenda.RegistrarPagamento(pagEspecie);
                        pagEspecie.ExibirDados();
                    }
                    else
                    {
                        System.Console.WriteLine("Não foi possível efetuar o pagamento, valor do pagamento insuficiente.");
                    }

                    break;
                case 2:
                    System.Console.WriteLine("Insira o numero da Transação: ");
                    int numeroTransação = Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("*** Pagamento por cartão aprovado? ***");
                    System.Console.WriteLine("**************  1 - Sim **************");
                    System.Console.WriteLine("**************  2 - Não **************");
                    int op3 = Convert.ToInt32(Console.ReadLine());
                    if (op3 == 1)
                    {
                        DateTime dataPagCard = DateTime.Now;
                        string resposta = "Aprovado";
                        Cartao pagCartao = new Cartao(novaVenda.Total, dataPagCard, resposta, numeroTransação);
                        novaVenda.RegistrarPagamento(pagCartao);
                        pagCartao.ExibirDados();
                    }
                    break;
                case 3:
                    DateTime dataPagCheque = DateTime.Now;
                    Cheque pagCheque = new Cheque(novaVenda.Total, dataPagCheque);
                    pagCheque.InserirCheque();
                    novaVenda.RegistrarPagamento(pagCheque);
                    pagCheque.ExibirDados();
                    break;
                case 4:
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Pagamento cancelado");
                    break;
            }
            break;
        case 5:
            novaVenda.ExibirDados();
            novaVenda.ExibirDadosVetPagamento();
            break;
        case 6:
            System.Console.WriteLine("***************** Sistema encerrado com sucesso *****************");
            break;
    }

}