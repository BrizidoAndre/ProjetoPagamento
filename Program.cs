// int opcao = '0';

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(@$"
 -------------------------------------------
|     Projeto Pagamento - Loja Virtual      |
|                                           |
|   1- Boleto                               |
|   2- Crédito                              |
|   3- Débito                               |
|   4- Cancelar Operação                    |
|                                           |
|   0- Sair/Fechar                          |
 -------------------------------------------

");
Console.WriteLine($"Seleciona a opção desejada: ");
Console.ResetColor();
int opcao = int.Parse(Console.ReadLine());
    

do
{
    switch (opcao)
    {
        case '1':

            break;

        case '2':

            break;

        case '3':

            break;

        case '4':

            break;

        case '0':

            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Opção inexistente! Tente novamente: ");
            Console.ResetColor();
            opcao = int.Parse(Console.ReadLine());
            break;
    }


} while (opcao != '0');