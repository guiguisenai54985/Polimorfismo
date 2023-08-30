using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivPolimorfismo.Atividade1
{
    class Diretor:Colaborador
    {
        public override void CalcularSalario(double salario)
        {
            double result = salario * 0.23;
            Console.WriteLine("o desconto do salario do diretor é de: " + result);
        }

    }
}
