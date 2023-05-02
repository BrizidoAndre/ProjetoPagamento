
namespace ProjetoPagamento
{
    public class PagamentoDebito : PagamentoCartao
    {
        private float saldo = 3000;

        public override void Pagar(float saldoAtual)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else if (saldo >= valor)
            {
                saldoAtual = saldo - valor;
                Console.WriteLine($"Pagamento de R${valor} realizado com sucesso. Novo saldo: R${saldoAtual}");
            }
            else
            {
                Console.WriteLine($"Erro! Tente novamente");
            }
        }
    }
}