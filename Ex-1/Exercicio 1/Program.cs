using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-Ler 5 elementos de um vetor A.
            //Construir um vetor B de mesmo tipo, observando a seguinte lei de formação:
            //Todo elemento de B deverá ser o cubo do elemento de A correspondente.


            //Declaração de variaveis
            const int VAL = 5;
            double[] A = new double[VAL];
            double[] B = new double[VAL];

            //Entrada de Dados
            for (int x = 0; x < VAL; x++)//Armazenando valores nos vetores
            {
                Console.Write("\nInforme o {0}º vetor de A:",x+1);
                A[x] = double.Parse(Console.ReadLine());//Armazenando no vetor de A
               
            }
            Console.Write("\nCalculando....");

            for (int x =0;x<VAL;x++)//Laço  de repetição de B
            {
                B[x] = (A[x] * A[x] * A[x]);//Vetor de A[x] Elevado ao ^3(cubo)

                Console.Write("\nO valor do "+(x+1)+"º vetor de A era:" + A[x]);

                Console.Write("\nO valor de B é :" + +B[x]);
            }
            Console.ReadKey();
            
        }
    }
}
