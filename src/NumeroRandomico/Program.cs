using System;

namespace NumeroRandomico
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int x = r.Next(10000000, 99999999);
            int y = r.Next(10000000, 99999999);
            int z = r.Next(10000000, 99999999);
            Console.WriteLine($"{x}\n{y}\n{z}");
        }
    }
}
