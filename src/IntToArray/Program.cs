using System;

namespace IntToArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] num = Console.ReadLine().ToCharArray();
            string[] s = new string[] { "zero", "um", "dois", "tres", "quatro", "cinco", "seis", "sete", "oito", "nove" };
            Console.WriteLine();
            for (int x=0; x<num.Length;x++)
            {
                string c = (num[x] % 2 == 0) ? "PAR" : "IMPAR";
                Console.WriteLine($"A posição é o {x} e o número é {num[x]} ({s[int.Parse(num[x].ToString())]}) que é {c}.");
            }
        }
    }
}
