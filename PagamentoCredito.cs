using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoPagamento;
namespace ProjetoPagamento
{
    public class PagamentoCredito : PagamentoCartao
    {
        private int parcelas;
        private float juros;
        private float limite = 2000;
        public override void Pagar()
        {
            if (valor > limite)
            {
                Console.WriteLine($"O valor ultrapassou o limite!");
            }
            else
            {
                Console.WriteLine(@$"
Quer dividir o valor em quantas parcelas?
Máximo de 12
até 6 - acrécimo de 5% de juros
de 7 até 12 - acrécimo de 8% de juros
0 - Não quero parcelar");
                parcelas = int.Parse(Console.ReadLine());
                if (parcelas < 7 && parcelas>0)
                {
                    juros = 0.05F;
                    valor = valor + (valor * juros);
                    Console.WriteLine($"O valor total ficará R${valor}");
                }
                if (parcelas>=7 && parcelas<=12)
                {
                    juros = 0.08F;
                    valor = valor + (valor * juros);
                    Console.WriteLine($"O valor total ficará R${valor}");
                }
                else
                {
                    Console.WriteLine($"Você não pode parcelar este número de vezes");
                }
            }
        }

    }
}