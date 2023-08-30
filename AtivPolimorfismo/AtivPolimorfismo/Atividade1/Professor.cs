using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivPolimorfismo.Atividade1
{
    class Professor : Colaborador
    {
        public override void CalcularSalario(double salario)
        {
            double result = salario * 0.18;
            Console.WriteLine("o desconto do salario padrão do INSS de professor é: " + result);
        }
    }
}
