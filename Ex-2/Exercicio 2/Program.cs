using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            const int TAV = 5;
            double[] A = new double[TAV];//Vetor A
            double[] B = new double[TAV];//Vetor B
            int x;

            //Entrada de Dados

            for(x=0;x<TAV;x++)
            {
                Console.Write("\nInforme o {0}º valor para o vetor de A:",x + 1);
                A[x] = double.Parse(Console.ReadLine());

                
            }
            Console.WriteLine("\nCalculando....");

            for(x=0;x<TAV;x++)
            {
                B[x] = (A[x] + 1);//soma dos vetores de A + 1


                Console.WriteLine("\nO  " + (x + 1) + "º valor de *A* :" + A[x]);
                Console.WriteLine("\nO  " + (x + 1) + "º valor de *B* :" + B[x]);
            }
            

            Console.ReadKey();
        }
    }
}
