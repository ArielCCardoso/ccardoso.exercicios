using System.Data;

namespace Curso.Udemy.CSharpCompleto2020.Capitulo6
{
    class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario(double p)
        {
            Salario += Salario * (p / 100);
        }
        public override string ToString()
        {
            return $"{Id}, {Nome}, {Salario}";
        }
    }
}
