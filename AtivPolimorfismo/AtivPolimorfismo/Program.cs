using AtivPolimorfismo.Atividade1;
using AtivPolimorfismo.Atividade2;
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
            //Imposto imposto = new Imposto();
            //imposto.CalcularSalario(2500);
            //imposto.CalcularIRRF(2500);
            //Console.WriteLine();

            //Colaborador colaborador = new Colaborador();
            //colaborador.CalcularSalarioProf(2500);
            //colaborador.CalcularIRRF(2500);
            //Console.WriteLine();

            //colaborador.CalcularSalarioCoor(3000);
            //colaborador.CalcularIRRF(3000);
            //Console.WriteLine();

            //colaborador.CalcularSalarioDir(2800);
            //colaborador.CalcularIRRF(3000);


            //Exercicio 2
            Corrente corrente = new Corrente();
            corrente.agencia = "Itau";
            corrente.conta = "corrente";
            corrente.nometitular = "julia";
            corrente.CalcularImposto(3500);
            Console.WriteLine();

            Poupanca poupanca = new Poupanca();
            poupanca.agencia = "Santander";
            poupanca.conta = "poupança";
            poupanca.nometitular = "igor";
            poupanca.CalcularImposto(4500);




            Console.ReadKey();
        }
    }
}
