using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivPolimorfismo.Atividade3
{
    class Veiculo
    {
        public string placa;
        public string cor;
        public string modelo;

        public virtual void CalcularValorCombustivel()
        {
            Console.WriteLine("qual a opção de combustivel? Alcool(1), Gasolina(2) ou Disel(3)?");
            int valorcombustivel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("quantos litros você gostarioa do por em seu veículo");
            double Litro = Convert.ToDouble(Console.ReadLine());


            if (valorcombustivel == 1)
            {
                double result = Litro * 3.99;
                Console.WriteLine("O total ficará: " + result);
            }
            else if (valorcombustivel == 2)
            {
                double result = Litro * 5.99;
                Console.WriteLine("O total ficará: " + result);
            }
            else if (valorcombustivel == 3)
            {
                double result = Litro * 6.99;
                Console.WriteLine("O total ficará: " + result);
            }
            else
            {
                Console.WriteLine("valor inválido");
            }
        }
        public virtual void CalcularTotal()
        {
            Console.WriteLine("Digite a quantidade de pessoas que irão na viagem");
            double qtdpessoas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de km a ser percorrida na viagem");
            double velocidade = Convert.ToDouble(Console.ReadLine());

            if (qtdpessoas == 2 && velocidade >= 50)
            {
                double result = velocidade * 25.00;
                Console.WriteLine("O total ficou: " + result);
            }
            else if (qtdpessoas == 2 && velocidade <= 50)
            {
                double result = velocidade * 18.00;
                Console.WriteLine("O total ficou: " + result);
            }
            else
            {
                double result = velocidade * 15.00;
                Console.WriteLine("O total ficou: " + result);
            }
        }
    }
}
