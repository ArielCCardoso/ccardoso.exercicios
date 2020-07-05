using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Curso.Udemy.CSharpCompleto2020
{
    class Capitulo3
    {
        private static bool Continue()
        {
            Console.Write("\nDeseja continuar? (y/N): ");
            return Console.ReadLine().ToUpper().Equals("Y");
        }
        public static void Soma()
        {
            int a, b;
            while (true)
            {
                Console.WriteLine("Informe o primeiro número: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o segundo número: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"O resultado da soma é: {a + b}\n");

                if (!Continue())
                    break;
                Console.Clear();
            }
        }
        public static void Area()
        {
            double raio, pi;
            pi = 3.14159;
            while (true)
            {
                Console.WriteLine("Informe o raio do círculo: ");
                raio = double.Parse(Console.ReadLine());
                
                Console.WriteLine($"A area do círculo é: {(pi * (Math.Pow(raio,2))).ToString("F4", CultureInfo.InvariantCulture)}\n");

                if (!Continue())
                    break;
                Console.Clear();
            }
        }
        public static void Operacao()
        {
            int a,b,c,d;
            while (true)
            {
                Console.WriteLine("Informe o primeiro número: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o segundo número: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o terceiro número: ");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o quarto número: ");
                d = int.Parse(Console.ReadLine());

                Console.WriteLine($"O resultado da operação é: {(a*b)-(c*d)}\n");

                if (!Continue())
                    break;
                Console.Clear();
            }
        }
        public static void Salario()
        {
            int matricula;
            decimal jornada, vHora;
            while (true)
            {
                Console.WriteLine("Informe a matricula do funcionário: ");
                matricula = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe a jornada trabalhada em horas: ");
                jornada = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor/hora do funcionário: ");
                vHora = decimal.Parse(Console.ReadLine());
                
                Console.WriteLine($"Segue demonstrativo de pagamento:\nFuncionário (matrícula): {matricula}\nSalario: R$ {(jornada*vHora).ToString("F2",CultureInfo.InvariantCulture)}\n\n");

                if (!Continue())
                    break;
                Console.Clear();
            }
        }
    }
}
