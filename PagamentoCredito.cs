namespace ProjetoPagamento
{
    public class PagamentoCredito : PagamentoCartao
    {
        public int Parcelas { get; private set; }
        public float Juros { get; private set; }
        public float Limite { get; private set; } = 2000;
        public override void Pagar()
        {
            if (valor > Limite)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O valor ultrapassou o limite!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(@$"
Quer dividir o valor em quantas parcelas?
Máximo de 12
até 6 - acrécimo de 5% de juros
de 7 até 12 - acrécimo de 8% de juros
0 - Não quero parcelar");
                Console.ResetColor();
                Parcelas = int.Parse(Console.ReadLine());
                if (Parcelas < 7 && Parcelas > 0)
                {
                    Juros = 0.05F;
                    valor = valor + (valor * Juros);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O valor total ficará R${valor}");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;                 
                    Console.WriteLine($"Deseja cancelar a operação? S/N");
                    Console.ResetColor();
                    string cancelarOperacao = Console.ReadLine().ToUpper();

                    if (cancelarOperacao == "N")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Operação concluída!");
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Operação cancelada!");
                        Console.ResetColor();

                    }

                }
                else if (Parcelas >= 7 && Parcelas <= 12)
                {
                    Juros = 0.08F;
                    valor = valor + (valor * Juros);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"O valor total ficará R${valor}");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;                 
                    Console.WriteLine($"Deseja cancelar a operação? S/N");
                    Console.ResetColor();
                    string cancelarOperacao = Console.ReadLine().ToUpper();

                    if (cancelarOperacao == "N")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Operação concluída!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Operação cancelada!");
                        Console.ResetColor();
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Você não pode parcelar este número de vezes");
                    Console.ResetColor();
                }
            }
        }

    }
}