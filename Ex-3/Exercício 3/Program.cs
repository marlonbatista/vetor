using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
           /* 3 - Ler três vetores(A, B) de uma dimensão com 5 elementos cada.
                Construir um vetor C, sendo este será a junção(união) dos dois outros vetores.
                Desta forma C deverá ter o dobro de elementos, ou seja, 10.Apresentar os elementos do vetor C.*/

            //Declaração de variavéis
           
            double[] A = new double[5];
            double[] B = new double[5];
            double[] C = new double[10];
            int x=0;

            //Entrada de Dados
            for(x=0;x<5;x++)
            {
                Console.Write("\nInforme o {0}º valor para A :",x+1);
                A[x] = double.Parse(Console.ReadLine());

            }
            for(x=0;x<5;x++)
            {
                Console.Write("\nInforme o {0}º valor para B:",x+1);
                B[x] = double.Parse(Console.ReadLine());
            }
            for (x = 0; x < 5; x++)
            {
                C[x] = A[x];
            }

            for (x = 5; x < 10; x++)
            {
                C[x] = B[x-5];
                
            }
            for (x = 0; x < 10; x++)
            {
                Console.Write("\nO {0}º valor de C é :"+ C[x],(x+1));
            }






                Console.ReadKey();
        
           
        }
    }
}
