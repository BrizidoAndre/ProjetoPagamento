namespace ProjetoPagamento
{
    public class PagamentoDebito : PagamentoCartao
    {
        public float saldo { get; private set; } = 3000;


        public override void Pagar()
        {
            if (valor > saldo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saldo insuficiente");
                Console.ResetColor();
            }
            else if (saldo >= valor)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;                 
                    Console.WriteLine($"Deseja continuar com a operação? S/N");
                    Console.ResetColor();
                    string cancelarOperacao = Console.ReadLine().ToUpper();

                    if (cancelarOperacao == "S")
                    {
                float saldoAtual = saldo - valor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Pagamento de R${valor} realizado com sucesso. Novo saldo: R${saldoAtual}");
                Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Operação concluída!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Operação cancelada!");
                        Console.ResetColor();
                    }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Erro! Tente novamente");
                Console.ResetColor();
            }
        }
    }
}