using System;

namespace Uri1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, num;
            n = int.Parse(Console.ReadLine());

            while (n > 10000)
            {
                Console.WriteLine("digite novamente");
                n = int.Parse(Console.ReadLine());
            }

            for (int c = 1; c <= 10000; c++)
            {
                if(c%n==2)
                {
                    Console.WriteLine(c);
                }

            }


        }
    }
}
