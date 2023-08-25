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
            Console.WriteLine("o desconto do salario padrão do INSS é de: " + result);
        }

        public override void CalcularIRRF(double irrf)
        {
            double result = irrf * 0.02;
            Console.WriteLine("o desconto do salario padrão do IRRF é de: " + result);
        }

         public virtual void CalcularSalarioProf(double salario)
        {
            double result = salario * 0.18;
            Console.WriteLine("o desconto do salario do professor é de: " + result);
        }

        public virtual void CalcularSalarioCoor(double salario)
        {
            double result = salario * 0.11;
            Console.WriteLine("o desconto do salario do coordenador é de: " + result);
        }

        public virtual void CalcularSalarioDir(double salario)
        {
            double result = salario * 0.23;
            Console.WriteLine("o desconto do salario do diretor é de: " + result);
        }
    }
}
