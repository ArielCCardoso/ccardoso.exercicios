using System;
using System.Globalization;

namespace Curso.Udemy.CSharpCompleto2020.Capitulo4
{
    class Exercicios
    {
        public static void AreaTriangulo()
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double areaX = x.Area();
            double areaY = y.Area();
            
            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }

        public static void Estoque()
        {
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {p}");
        }

        public static void Retangulo()
        {
            Retangulo r = new Retangulo();

            Console.Write("Entre com a Largura do Retangulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com a Altura do Retangulo: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(r);
        }

        public static void Salario()
        {
            Funcionario f = new Funcionario();

            Console.Write("Informe o nome do funcionário: ");
            f.Nome = Console.ReadLine();

            Console.Write("Informe o salário bruto do funcionário: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Informe o imposto sobre o salário do funcionário: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Dados inseridos - {f}\n");

            Console.Write("Informe o aumento do funcionário: ");
            f.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados - {f}\n");
        }

        public static void MediaAluno()
        {
            Aluno a = new Aluno();

            Console.Write("Informe o nome do aluno: ");
            a.Nome = Console.ReadLine();

            Console.Write("Informe a nota do primeiro semestre: ");
            a.Notas.Add(double.Parse(Console.ReadLine()));
            Console.Write("Informe a nota do segundo semestre: ");
            a.Notas.Add(double.Parse(Console.ReadLine()));
            Console.Write("Informe a nota do terceiro semestre: ");
            a.Notas.Add(double.Parse(Console.ReadLine()));

            Console.WriteLine("Nota final do aluno: " + a.NotaFim);
            Console.WriteLine(a.Aprovado() ? "Aprovado!!!" : $"Reprovado!!!\nFaltaram {a.NotaRestante()} pontos.");
        }
    }
}
