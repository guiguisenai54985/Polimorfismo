using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivPolimorfismo.Atividade2
{
   class Poupanca:Conta
    {
        public override void CalcularImposto(double saque)
        {
            double result = saque * 0.06;
            Console.WriteLine("o desconto da poupança é de: " +result);
        }
    }
}
