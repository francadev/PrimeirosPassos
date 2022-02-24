using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tempo tempo1;// variavel capaz de acessar o objeto
            tempo1 = new Tempo(); // new cria o objeto na memoria e devolve uma referencia para ele

            tempo1.hora = 9;
            tempo1.minuto = 42;
            tempo1.segundo = 28;

            Console.WriteLine("tempo.hora    {0:D2}", tempo1.hora);
            Console.WriteLine("tempo.minuto  {0:D2}", tempo1.minuto);
            Console.WriteLine("tempo.segundo {0:D2}", tempo1.segundo);

            Tempo tempo2 = new Tempo();

            tempo2.hora = 23;
            tempo2.minuto = 5;
            tempo2.segundo = 30;

            Console.WriteLine("\ntempo.hora    {0:D2}", tempo2.hora);
            Console.WriteLine("tempo.minuto  {0:D2}", tempo2.minuto);
            Console.WriteLine("tempo.segundo {0:D2}", tempo2.segundo);

            Console.WriteLine("\nFim da execução!");
        }
    }
}
