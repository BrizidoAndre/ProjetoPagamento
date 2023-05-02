using ProjetoPagamento;

string opcao = "";
Boleto PagarBoleto = new Boleto();
Pagamento pague = new Pagamento();
PagamentoDebito debito = new PagamentoDebito();



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
|                                           |
|   0- Sair/Fechar                          |
 -------------------------------------------
");
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
            Console.WriteLine($"Qual o valor do seu pagamento?: ");
            PagarBoleto.valor = float.Parse(Console.ReadLine());


            Console.WriteLine(PagarBoleto.CodigoDeBarras());
            PagarBoleto.Registrar();
            menu();
            break;





        case "2":
            debito.SalvarCartao();

            break;

        case "3":
            Console.WriteLine($"Qual o valor do seu pagamento?: ");
            debito.valor = float.Parse(Console.ReadLine());
            debito.SalvarCartao();
            debito.Pagar();
            menu();
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
Console.WriteLine(pague.Cancelar());
Console.ResetColor();