using ProjetoPagamento;

string opcao = "";
Boleto PagarBoleto = new Boleto();
Pagamento Pague = new Pagamento();
PagamentoDebito Debito = new PagamentoDebito();
PagamentoCredito Credito = new PagamentoCredito();


void menu()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(@$"
 -------------------------------------------
|     Projeto Pagamento - Loja Virtual      |
|                                           |
|   1- Boleto                               |
|   2- Crédito                              |
|   3- Débito                               |
|   4- Cartões Salvos                       |
|                                           |
|   0- Sair/Fechar                          |
 -------------------------------------------
");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($"Seleciona a opção desejada: ");
    Console.ResetColor();
    opcao = Console.ReadLine();
}

do
{
    menu();
    switch (opcao)
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Qual o valor do seu pagamento?: ");
            Console.ResetColor();
            PagarBoleto.valor = float.Parse(Console.ReadLine());
            Console.WriteLine(PagarBoleto.CodigoDeBarras());
            PagarBoleto.Registrar();
            break;

        case "2":
            Debito.SalvarCartao();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Qual o valor do seu pagamento?: ");
            Credito.valor = float.Parse(Console.ReadLine());
            Console.ResetColor();
            Credito.Pagar();
            break;

        case "3":
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Qual o valor do seu pagamento?: ");
            Console.ResetColor();
            Debito.valor = float.Parse(Console.ReadLine());
            Debito.SalvarCartao();
            Debito.Pagar();
            break;

        case "4":
            Debito.DadosCartao();
            break;

        case "0":
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Opção inexistente! Tente novamente: ");
            Console.ResetColor();
            opcao = Console.ReadLine();
            break;
    }

} while (opcao != "0");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(Pague.Cancelar());
Console.ResetColor();