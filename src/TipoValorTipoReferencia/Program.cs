using System;

namespace TipoValorTipoReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste t1, t2, t3;
            string s = new string("");
            t1 = new Teste("Ariel", "Monte Santo", 99999);
            t2 = t1;
            t2.Set("Ariel", "Sao Paullo", 1000000000);
            t3 = new Teste("Ariel", "Monte Santo");

            Console.WriteLine("Hello World!");
            Console.WriteLine($"{t1}\n{t2}\n{t3}");
        }
    }
}
