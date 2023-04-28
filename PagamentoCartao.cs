namespace ProjetoPagamento
{
    public abstract class PagamentoCartao
    {
        public string Bandeira;
        public string NumeroCartao;
        public string Titular;
        public string CVV;



        public string SalvarCartao(string cartaoSalvo)
        {          
            
            return cartaoSalvo;
        }
        public void Pagar()
        {
            
        }
    }
}