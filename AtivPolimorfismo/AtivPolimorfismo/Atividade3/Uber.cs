using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivPolimorfismo.Atividade3
{
    class Uber : Veiculo
    {
        private int qtdereodas;
        private int qtdepassageiros;



        public override void CalcularTotal()
        {
            Console.WriteLine("Digite a quantidade de km a aser percorrido na viagem");
            double km = Convert.ToDouble(Console.ReadLine());

            double result = km * 11.99;
            Console.WriteLine("O total ficou em: " + result);
        }
        public void EscolherVeiculo(double tipoveiculo)
        {
            if (tipoveiculo == 1)
            {
                Console.WriteLine("Digite a quantidade de pessoas que gostaria de compartilhar a viagem");
                int qtdpessoas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A qantidade de pessoas que irão nessta viagem será: " + qtdpessoas);
            }
            else if (tipoveiculo == 2)
            {
                Console.WriteLine("Parabéns, você está escolhendo um veículo ecológico");
            }
            else if (tipoveiculo == 3)
            {
                Console.WriteLine("digite a data em que gostaria de reservar o veículo, o horário, e a quantidade de pessoas que irão participar da viagem e o destino");
                int data = Convert.ToInt32(Console.ReadLine());
                double horario = Convert.ToInt32(Console.ReadLine());
                int pessoas = Convert.ToInt32(Console.ReadLine());
                string destino = Convert.ToString(Console.ReadLine());
                Console.WriteLine("a data escolhida foi: " + data + "o horario que você escolheu para reservar o veiculo foi: " + horario + "a quantidade de pessoas que vão nessa viagem é: " + pessoas + "o destino da viagem é: " + destino);
            }
            else
            {
                Console.WriteLine("Nenhum veículo escolhido, você irá fazer a viagem com um veículo padrão da empresa. Boa viagem!!!");
            }
        }

    }
}
