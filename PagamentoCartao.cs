namespace ProjetoPagamento
{
    public class PagamentoCartao
    {
        public string Bandeira;
        public string NumeroCartao;
        public string Titular;
        public string CVV;

        

        public string SalvarCartao(string cartaoSalvo)
        {
            Console.WriteLine($"Para realizarmos o pagamento do seu produto e preciso que nos informe os dados do cartao :");
            Console.WriteLine(@$"
             _____________________________
            |Informe a Bandeira do Cartao:|
            |-----------------------------|
            |1) Visa                      |
            |2) MasterCard                |
            |3) Elo                       |
            |4) American Express          |
            |_____________________________|
            ");
            Bandeira = Console.ReadLine();
            
            Console.Write($"Informe o numero do cartao :");
            NumeroCartao = Console.ReadLine();

            Console.Write($"Informe o nome do Titular do cartao :");
            Titular = Console.ReadLine();
            
            Console.WriteLine($"Informe o CVV do cartao a ser cadastrado (XXX) :");
            CVV = Console.ReadLine();            
            
            return cartaoSalvo;
        }
        public void Pagar()
        {
           Console.WriteLine($"Seu pagamento foi efetuado com sucesso !");
            
        }
    }
}