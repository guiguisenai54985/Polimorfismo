using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivPolimorfismo.Atividade1
{
    class Imposto
    {
        public virtual void CalcularSalario(double salario)
        {
            double result = salario * 0.14;
            Console.WriteLine("o desconto do salario padrão do INSS é de: " + result);
        }

        public virtual void CalcularIRRF(double irrf)
        {
            double result = irrf * 0.02;
            Console.WriteLine("o desconto do salario padrão do IRRF é de: " + result);
        }

    }
}
