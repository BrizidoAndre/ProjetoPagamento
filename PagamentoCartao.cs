namespace ProjetoPagamento
{
    public abstract class PagamentoCartao : Pagamento
    {
        public string Bandeira { get; set; }
        public string NumeroCartao { get; private set; }
        public string Titular { get; private set; }
        public string CVV { get; private set; }


        abstract public void Pagar();
        public void DadosCartao()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@$"
Nome do Titular: {Titular}
Numero do Cartão: {NumeroCartao}");
            switch (Bandeira)
            {
                case "1":
                    Console.WriteLine($"Bandeira do Cartão: Visa");
                    break;
                case "2":
                    Console.WriteLine($"Bandeira do Cartão: MasterCard");
                    break;
                case "3":
                    Console.WriteLine($"Bandeira do Cartão: Elo");
                    break;
                case "4":
                    Console.WriteLine($"Bandeira do Cartão: American Express");
                    break;
                default:
                    break;
            }
            Console.ResetColor();

        }

        public void SalvarCartao()
        {
            Bandeira = "";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Digite o CVV do cartão:");
            Console.ResetColor();
            CVV = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Digite o nome do titular do cartão:");
            Console.ResetColor();
            Titular = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Digite o número do cartão:");
            Console.ResetColor();
            NumeroCartao = Console.ReadLine();
            Console.ResetColor();

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
                Console.ResetColor();

                Bandeira = Console.ReadLine();
                switch (Bandeira)
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
                        Environment.Exit(0);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Opção inexistente! Tente novamente: ");
                        Console.ResetColor();
                        Bandeira = Console.ReadLine();
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Informações do cartão salvas com sucesso!");
                Console.ResetColor();
                break;
            } while (Bandeira != "0");

        }

    }
}