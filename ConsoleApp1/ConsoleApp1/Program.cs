using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int algarismoA, algarismoB;

            string[] valores = Console.ReadLine().Split(' ');

            algarismoA = int.Parse(valores[0]);
            algarismoB = int.Parse(valores[1]);

            if (algarismoA % algarismoB == 0 || algarismoB % algarismoA == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
            //Console.ReadLine();
        }
    }
}
