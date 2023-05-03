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
                float saldoAtual = saldo - valor;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Pagamento de R${valor} realizado com sucesso. Novo saldo: R${saldoAtual}");
                Console.ResetColor();
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