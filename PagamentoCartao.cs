namespace ProjetoPagamento
{
    public abstract class PagamentoCartao : Pagamento
    {
        public string Bandeira { get; set; }
        public string NumeroCartao { get; set; }
        public string Titular { get; set; }
        public string CVV { get; set; }



        public string SalvarCartao()
        {
            Console.WriteLine("Digite o CVV do cartão:");
            this.CVV = Console.ReadLine();

            Console.WriteLine("Digite o nome do titular do cartão:");
            this.Titular = Console.ReadLine();

            Console.WriteLine("Digite o número do cartão:");
            this.NumeroCartao = Console.ReadLine();

            Console.WriteLine("Digite a bandeira do cartão:");
            this.Bandeira = Console.ReadLine();

            return @$"Informações do cartão salvas com sucesso!
            Sendo as informacoes :
            Bandeira : {this.Bandeira}
            Titular do Cartao : {this.Titular}
            CVV : {this.CVV}
            Numero do Cartao : {this.NumeroCartao}";
        }

        public abstract void Pagar();

       }
}