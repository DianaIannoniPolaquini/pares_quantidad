using System;

namespace VETOR_PARES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int[] v = new int[x];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < x; i++)
            {
                v[i] = int.Parse(s[i]);
            }
            

            for (int i = 0; i < x; i++)
            {
                if (v[i] % 2 == 0)
                {

                    Console.Write(v[i] + " ");
                }
            }
            Console.WriteLine();
            int cont = 0;
            for (int i = 0;i<x; i++)
            {
                if (v[i] % 2 == 0)
                {
                    cont++;
                }
            }
            Console.WriteLine(cont);
        }
        

    }
}
