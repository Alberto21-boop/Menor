using System;

namespace Menor
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Fazer um programa para ler três números inteiros. Em seguida, mostrar qual é o menor
            //dentre os três números lidos. Em caso de empate, mostrar apenas uma vez.

            int A, B, C;

            Console.WriteLine("Boa tarde, digite por favor três numeros inteiros: ");
            Console.Write("Primeiro Número: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Segundo Número: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Terceiro Número: ");
            C = int.Parse(Console.ReadLine());

            if((A < B) && (A < C))
            {
                Console.WriteLine("MENOR = " + A);
            }
            else if((B < C) && (B < A))
            {
                Console.WriteLine("MENOR = " + B);
            }
            else
            {
                Console.WriteLine("MENOR = " + C);
            }

        }
    }
}