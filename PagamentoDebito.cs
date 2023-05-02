
namespace ProjetoPagamento
{
    public class PagamentoDebito : PagamentoCartao
    {
        private float saldo = 3000;

        public void Pagar(float valor, float saldoAtual)
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

        public void SalvarCartao()
        {
            Console.WriteLine("Digite o CVV do cartão:");
            CVV = Console.ReadLine();

            Console.WriteLine("Digite o nome do titular do cartão:");
            Titular = Console.ReadLine();

            Console.WriteLine("Digite o número do cartão:");
            NumeroCartao = Console.ReadLine();

            Console.WriteLine("Digite a bandeira do cartão:");
            Bandeira = Console.ReadLine();

            Console.WriteLine("Informações do cartão salvas com sucesso!");
        }
    }
}