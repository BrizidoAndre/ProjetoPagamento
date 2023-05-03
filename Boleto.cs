using ProjetoPagamento;
namespace ProjetoPagamento
{
    public class Boleto : Pagamento
    {
        private Random random = new Random();
        public string CodigoDeBarras()
        {
            int num1 = random.Next(1, 2000000000);
            int num2 = random.Next(1, 2000000000);
            int num3 = random.Next(1, 2000000000);

            string codigo = @"
            -------------
              " + num1.ToString() + @"
              " + num2.ToString() + @"
              " + num3.ToString() + @"
            -------------";
           
            return codigo;
        }
        private float desconto = 0.88F;
        public void Registrar()
        {
            float valorBoleto = (float)Math.Round(valor * desconto, 2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"No dia de {date1}");
            Console.WriteLine($"O total a ser pago é de: R$ {valorBoleto}");
            Console.ResetColor();
        }
    }
}