using System;
using System.Globalization;

namespace Curso.Udemy.CSharpCompleto2020.Capitulo4
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt((Math.Pow(Largura, 2)) + Math.Pow(Altura, 2));
        }

        public override string ToString()
        {
            return $"Area: {Area().ToString("F2", CultureInfo.InvariantCulture)}\nPerimetro: {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\nDiagonal: {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
