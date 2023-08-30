using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivPolimorfismo.Atividade3
{
    class Moto : Veiculo
    {
        private int qtdrodas;
        private int qtdpassageiros;


        public override void CalcularValorCombustivel()
        {
            Console.WriteLine("qual a opção de combustivel? Alcool(1) ou Gasolina(2)?");
            int valorcombustivel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("quantos litros você gostarioa do por em seu veículo");
            double Litro = Convert.ToDouble(Console.ReadLine());


            if (valorcombustivel == 1)
            {
                double result = Litro * 4.99;
                Console.WriteLine("O total ficará: " + result);
            }
            else if (valorcombustivel == 2)
            {
                double result = Litro * 4.99;
                Console.WriteLine("O total ficará: " + result);
            }
            else
            {
                Console.WriteLine("você digitou um combustivel inválido");
            }

        }
        public override void CalcularTotal()
        {
            Console.WriteLine("Digite a quantidade de km a ser percorrida na viagem");
            double velocidade = Convert.ToDouble(Console.ReadLine());

            if (velocidade >= 100 || velocidade <= 150)
            {
                double result = velocidade * 20.00;
                Console.WriteLine("O total ficou: " + result);
            }
            else if (velocidade >= 50)
            {
                double result = velocidade * 10.00;
                Console.WriteLine("O total ficou: " + result);
            }
            else
            {
                double result = velocidade * 5.00;
                Console.WriteLine("O total ficou: " + result);
            }
        }
    }
}
