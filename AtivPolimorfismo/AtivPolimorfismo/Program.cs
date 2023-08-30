using AtivPolimorfismo.Atividade1;
using AtivPolimorfismo.Atividade2;
using AtivPolimorfismo.Atividade3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1
            Imposto imposto = new Imposto();
            imposto.CalcularSalario(2900);
            imposto.CalcularIRRF(2500);
            Console.WriteLine();

            Colaborador colaborador = new Colaborador();
            colaborador.CalcularSalario(2600);
            colaborador.CalcularIRRF(2300);
            Console.WriteLine();

            Coordenador coordenador = new Coordenador();
            coordenador.CalcularSalario(3000);
            coordenador.CalcularIRRF(3000);
            Console.WriteLine();

            Diretor diretor = new Diretor();
            diretor.CalcularSalario(4200);
            diretor.CalcularIRRF(3500);
            Console.WriteLine();

            Professor professor = new Professor();
            professor.CalcularSalario(3000);
            professor.CalcularIRRF(4000);



            //Exercicio 2
            //Corrente corrente = new Corrente();
            //corrente.agencia = "Itau";
            //corrente.conta = "corrente";
            //corrente.nometitular = "julia";
            //corrente.CalcularImposto(3500);
            //Console.WriteLine();

            //Poupanca poupanca = new Poupanca();
            //poupanca.agencia = "Santander";
            //poupanca.conta = "poupança";
            //poupanca.nometitular = "igor";
            //poupanca.CalcularImposto(4500);

            //Exercicio 3
            Veiculo veiculo = new Veiculo();
            veiculo.placa = "fbyf9g5";
            veiculo.cor = "branca";
            veiculo.modelo = "camaro";
            veiculo.CalcularValorCombustivel();
            veiculo.CalcularTotal();

            Moto moto = new Moto();
            moto.cor = "Preto";
            moto.modelo = "ninja";
            moto.placa = "rtvbnm8";
            moto.CalcularValorCombustivel();
            moto.CalcularTotal();

            Taxi taxi = new Taxi();
            taxi.modelo = "santana";
            taxi.placa = "dcfvgb9";
            taxi.cor = "amarelho";
            taxi.CalcularValorCombustivel();
            taxi.CalcularTotal();

            Uber uber = new Uber();
            Console.WriteLine("digite o tipo de uber você gostaria de viajar: 1-UberXShare" + 1 + ", 2-UberGreen" + 2 + "ou 3-UberReserve" + 3);
            double tipoveiculo = Convert.ToDouble(Console.ReadLine());
            uber.CalcularTotal();
            uber.EscolherVeiculo(tipoveiculo);
            uber.placa = "hfjgjr45";
            uber.cor = "verde";
            uber.modelo = "corola";



            Console.ReadKey();
        }
    }
}
