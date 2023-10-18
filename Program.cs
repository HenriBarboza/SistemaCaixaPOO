using TrabalhoHerancaComposicaoVenda;

// Produto p1 = new Produto();
// p1.CadastrarProudtos();
// Produto p2 = new Produto();
// p2.CadastrarProudtos();
int op = 0;
int posicaoAtual = 0;
Produto[] produtos = null;
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
                for (int i = 0; i < posicaoAtual; i++)
                {
                    produtos[i].ExibirEstoque();
                }
            }
            else
            {
                Console.WriteLine("Nenhum produto cadastrado.");
            }
            break;
        case 3:
            System.Console.WriteLine("3");
            break;
        case 4:
            System.Console.WriteLine("4");
            break;
        case 5:
            System.Console.WriteLine("5");
            break;
        case 6:
            break;
    }

}