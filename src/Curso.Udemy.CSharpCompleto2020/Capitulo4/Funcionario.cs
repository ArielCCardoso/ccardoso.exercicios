namespace Curso.Udemy.CSharpCompleto2020.Capitulo4
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (porcentagem / 100) * SalarioBruto; 
        }
        public override string ToString()
        {
            return $"Funcionário: {Nome}, salário líquido: R$ {SalarioLiquido()}.";
        }
    }
}
