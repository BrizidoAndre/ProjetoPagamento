namespace ProjetoPagamento
{
    public abstract class PagamentoCartao : Pagamento
    {
        public string Bandeira { get; set; }
        public string NumeroCartao { get; set; }
        public string Titular { get; set; }
        public string CVV { get; set; }



        public abstract string SalvarCartao(string cartaoSalvo);

        public abstract void Pagar();

    }
}