using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivPolimorfismo.Atividade1
{
    class Colaborador:Imposto
    {
        public override void CalcularSalario(double salario)
        {
            double result = salario * 0.14;
            Console.WriteLine("o desconto do salario padrão do colaborador do INSS é de: " + result);
        }

        public override void CalcularIRRF(double irrf)
        {
            double result = irrf * 0.02;
            Console.WriteLine("o desconto do salario padrão do IRRF é de: " + result);
        }
    }
}
