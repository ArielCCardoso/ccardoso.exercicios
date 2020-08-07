namespace Curso.Udemy.CSharpCompleto2020.Capitulo6
{
    class Quartos
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public override string ToString() => $"Quarto {Numero}: {Nome}, {Email}.";
    }
}
