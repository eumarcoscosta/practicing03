using System;
using System.Globalization;
using Internal;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int n, i = 0;

            Console.WriteLine("Insira abaixo o numero: ");
            n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            string[] vetor = Console.ReadLine().Split(' ');

            for (i = 0; i < n; i++)
            {
                vet[i] = int.Parse(vetor[i]);
            }


            int counter = 0;
            for (i = 0; i < n; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    counter++;
                    Console.WriteLine(vet[i]);
                }
            }

            Console.WriteLine(counter);
        }
    }
}