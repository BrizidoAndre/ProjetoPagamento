string bandeira = "";
string opcao = "";

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
opcao = Console.ReadLine();

do
{
    switch (opcao)
    {
        case "1":

            break;





        case "2":

        do
        {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@$"
 -------------------------------------------
|     Selecione a bandeira do cartão        |
|                                           |
|   1- Visa                                 |
|   2- MasterCard                           |
|   3- Elo                                  |
|   4- American Express                     |
|                                           |
|   0- Sair/Fechar                          |
 -------------------------------------------
        ");

            Console.WriteLine($"Selecione a bandeira:");

            bandeira = Console.ReadLine();
            Console.ResetColor();
            switch (bandeira)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Bandeira selecionada: Visa");
                    Console.ResetColor();
                    break;

                case "2":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Bandeira selecionada: MasterCard");
                    Console.ResetColor();
                    break;

                case "3":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Bandeira selecionada: Elo");
                    Console.ResetColor();
                    break;

                case "4":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Bandeira selecionada: American Express");
                    Console.ResetColor();
                    break;

                case "0":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Fechando... Obrigado!");
                    Console.ResetColor();
                    
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Opção inexistente! Tente novamente: ");
                    Console.ResetColor();
                    bandeira = Console.ReadLine();
                    break;
            }
        } while (bandeira != "0");
            break; 








        case "3":

            break;

        case "4":

            break;

        case "0":
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Fechando... Obrigado!");
            Console.ResetColor();

            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Opção inexistente! Tente novamente: ");
            Console.ResetColor();
            opcao = Console.ReadLine();
            break;
    }


} while (opcao != "0");