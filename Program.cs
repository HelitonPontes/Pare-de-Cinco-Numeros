using System;

namespace Pare_de_Cinco_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 0;
            for (i = 1; i < 5; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n >= 0)
                {
                    j = j + 1;
                }

            }
            Console.WriteLine(j + " valores positivos");

            Console.ReadKey();
        }
    }
}
