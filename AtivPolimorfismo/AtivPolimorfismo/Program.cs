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




            Console.ReadKey();
        }
    }
}
