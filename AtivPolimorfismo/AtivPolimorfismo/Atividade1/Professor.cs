using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivPolimorfismo.Atividade1
{
    class Professor : Colaborador
    {
        public virtual void CalcularSalario2(double salario)
        {
            double result = salario * 0.18;
            Console.WriteLine("o desconto do salario padrão do INSS é de: " + result);
        }
    }
}
