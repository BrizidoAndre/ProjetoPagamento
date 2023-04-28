
namespace ProjetoPagamento
{
    public class PagamentoDebito
    {

        private float saldo = 3000;

        public void EfetuarPagamento(float valor, float saldoFinal)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else if (saldo >= valor)
            {
                saldoFinal = saldo - valor;
                Console.WriteLine($"Pagamento de R${valor} realizado com sucesso. Novo saldo: R${saldoFinal}");
            }
            else
            {
                Console.WriteLine($"Erro! Tente novamente");
            }
        }
    }
}




// Console.WriteLine($"Para realizarmos o pagamento do seu produto e preciso que nos informe os dados do cartao :");
//             Console.WriteLine(@$"
//              ___________
//             |Informe a Bandeira do Cartao:|
//             |-----------------------------|
//             |1) Visa                      |
//             |2) MasterCard                |
//             |3) Elo                       |
//             |4) American Express          |
//             |___________|
//             ");
//             Bandeira = Console.ReadLine();
            
//             Console.Write($"Informe o numero do cartao :");
//             NumeroCartao = Console.ReadLine();

//             Console.Write($"Informe o nome do Titular do cartao :");
//             Titular = Console.ReadLine();
            
//             Console.WriteLine($"Informe o CVV do cartao a ser cadastrado (XXX) :");
//             CVV = Console.ReadLine();