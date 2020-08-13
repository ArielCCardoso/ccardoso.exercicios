using System;
using System.Collections.Generic;

namespace Curso.Udemy.CSharpCompleto2020.Capitulo6
{
    class Exercicios
    {
        private static bool Continue()
        {
            Console.Write("\nDeseja continuar? (y/N): ");
            return Console.ReadLine().ToUpper().Equals("Y");
        }
        public static void Aluguel()
        {
            Quartos[] q = new Quartos[10];
            Console.Write("Informe quantos alugueis deseja cadastrar? ");
            int x = int.Parse(Console.ReadLine());
            for (int y = 1; y <= x; y++)
            {
                Console.WriteLine($"Cadastro de novo aluguel #{y}");
                Console.Write("Informe o nome do aluno: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o e-mail do aluno: ");
                string email = Console.ReadLine();
                Console.Write("Informe o quarto que deseja alugar: ");
                int num = int.Parse(Console.ReadLine());

                q[num - 1] = new Quartos { Nome = nome, Email = email, Numero = num };

                //if (!Continue())
                //    break;
                //Console.Clear();
            }
            Console.WriteLine("Quartos ocupados:");
            foreach (Quartos qq in q)
            {
                if (qq != null)
                    Console.WriteLine(qq);
            }
        }

        public static void ListSalario()
        {
            int id = 0;
            string nome = null;
            double salario = 0;
            Funcionario f;
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.Write("Informe quantos funcionarios deseja cadastrar? ");
            int x = int.Parse(Console.ReadLine());
            for (int y = 1; y <= x; y++)
            {
                Console.WriteLine($"Cadastro do funcionário #{y}");
                Console.Write("Informe o id do funcionario: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Informe o nome do funcionario: ");
                nome = Console.ReadLine();
                Console.Write("Informe o salario do funcionario: ");
                salario = double.Parse(Console.ReadLine());

                Console.WriteLine("\n\n---------------------------------------------\n\n");

                funcionarios.Add(new Funcionario(id, nome, salario));

            }

            Console.Write("Informe o Id do funcionario que irá receber o aumento: ");
            id = int.Parse(Console.ReadLine());
            f = funcionarios.Find(x => x.Id == id);
            if (f != null)
            {
                Console.Write("Informe o percentual de aumento do funcionario {0}: ", f.Nome);
                double p = double.Parse(Console.ReadLine());
                f.AumentoSalario(p);
            }
            else
                Console.WriteLine("Este funcionário não existe!!!");

            Console.WriteLine("Lista atualizada:");
            foreach (Funcionario _f in funcionarios)
            {
                Console.WriteLine(_f);
            }
        }

        public static void MatrizResolvido()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);

        }

        public static void Matriz()
        {

            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
