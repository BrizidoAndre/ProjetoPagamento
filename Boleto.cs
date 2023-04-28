using ProjetoPagamento;
namespace ProjetoPagamento
{
    public class Boleto
    {
        private string codigoBarras;
        private float desconto = 0.88F;
        public void Registrar(float valorPago, DateTime data){
            float valorBoleto = (float) Math.Round(valorPago * desconto, 2);
            Console.WriteLine($"No dia de {data}");
            Console.WriteLine($"O total a ser pago é de: R$ {valorBoleto}");
        }
    }
}