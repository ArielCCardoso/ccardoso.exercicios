using System;
using System.Globalization;

namespace Curso.Udemy.CSharpCompleto2020.Capitulo3
{
    class Exercicios
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
        public static void Login()
        {
            Console.Write("Informe sua senha...");
            while(Console.ReadLine() != "2020") //Se fizer a conversão para inteiro em casos de 0 a esquerda pode falhar a condição
            {
                Console.WriteLine("Você errou a senha!!!\nDigite a senha novamente...");
            }
        }
        public static void Cartesiano()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }
        }
        public static void PostoDeCombustivel()
        {
            int alcool, diesel, gasolina;
            alcool = diesel = gasolina = 0;

            int tipo = 0;

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool =+ 1;
                }
                else if (tipo == 2)
                {
                    gasolina =+ 1;
                }
                else if (tipo == 3)
                {
                    diesel =+ 1;
                }
                Console.Clear();
                Console.WriteLine("Informe seu combustivel preferido com o numero correspondente:\n1.Álcool\n2.Gasolina\n3.Diesel\n4.Fim\n");
                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito Obrigado!");
            Console.WriteLine($"Alcool: {alcool}\nDiesel: {diesel}\nGasolina: {gasolina}");
        }
        public static void Impar()
        {
            Console.Write("Informe um valor interio: ");
            int v = int.Parse(Console.ReadLine());
            for(int x=1; x<=v;x++)
            {
                if(x%2!=0)
                    Console.WriteLine(x);
            }
        }
    }
}
