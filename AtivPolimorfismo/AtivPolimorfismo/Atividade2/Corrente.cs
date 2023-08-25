using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivPolimorfismo.Atividade2
{
     class Corrente: Conta
    {

        public override void CalcularImposto(double saque)
        {
            double result = saque * 0.15;
            Console.WriteLine("o desconto da conta corrente é: " + result);
        }
    }
}
