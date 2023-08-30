using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivPolimorfismo.Atividade3
{
    class Taxi : Veiculo
    {
        private int qtdrodas;
        private int qtdpassageiros;



        public override void CalcularValorCombustivel()
        {
            Console.WriteLine("qual a opção de combustivel?" + 1 + "Alcool(1)," + 2 + "Gasolina(2)" + 3 + "Híbrido(3)" + 4 + "GasGNV(4) ou" + 5 + "Disel(5)?");
            int valorcombustivel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("quantos litros você gostarioa do por em seu veículo");
            double Litro = Convert.ToDouble(Console.ReadLine());

            switch (valorcombustivel)
            {
                case 1:
                    double result = (Litro * 4.99) + 20.00;
                    Console.WriteLine("O total ficou: " + result);
                    break;
                case 2:
                    double result2 = (Litro * 6.99) + 40.00;
                    Console.WriteLine("O total ficou: " + result2);
                    break;
                case 3:
                    Console.WriteLine("Digite quantas horas gostaria de deixar o veículo carregando?");
                    double qtdhoras = Convert.ToDouble(Console.ReadLine());
                    double resul3 = (qtdhoras * 1000.00) + 200.00;
                    Console.WriteLine("o total ficou: " + resul3);
                    break;
                case 4:
                    Console.WriteLine("“Será cobrado uma taxa fixa de R$300,00");
                    break;
                case 5:
                    double result5 = (Litro * 7.99) + 25.00;
                    break;
                default:
                    Console.WriteLine("valor inválido");
                    break;
            }
        }
        public override void CalcularTotal()
        {
            Console.WriteLine("Digite a quantidade de km a ser percorrida na viagem");
            double velocidade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de pessoas que irão na viagem");
            double qtdpassageiros = Convert.ToDouble(Console.ReadLine());

            if (qtdpassageiros == 2 && velocidade >= 30)
            {
                double result = velocidade * 20.00;
                Console.WriteLine("O total ficou: " + result);
            }
            else if (qtdpassageiros == 3 && velocidade >= 30)
            {
                double result = velocidade * 35.00;
                Console.WriteLine("O total ficou: " + result);
            }
            else if (qtdpassageiros == 4 && velocidade >= 30)
            {
                double result = velocidade * 50.00;
                Console.WriteLine("O total ficou: " + result);
            }
            else if (qtdpassageiros == 2 || qtdpassageiros == 3 || qtdpassageiros == 4 && velocidade <= 30)
            {
                double result = velocidade * 10.00;
                double result2 = qtdpassageiros / result;
                Console.WriteLine("O valor a ser pago por pessoa será: " + result2);

            }
            else
            {
                double result = velocidade * 18.00;
                Console.WriteLine("O valor a aser pago na viagem será: " + result);
            }
        }
    }
}
