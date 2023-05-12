using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPagamento
{
    public class Pagamento
    {


        //Propriedades

        public float valor;

        public DateTime date1 { get; private set; } = DateTime.Now;



        //Metodos

        public string Cancelar()
        {


            return @"A sessão de pagamento foi cancelada.
Inicie outra sessão para acessar as opções novamente.";


        }

    }
}