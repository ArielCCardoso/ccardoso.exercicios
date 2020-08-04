using System.Collections.Generic;

namespace Curso.Udemy.CSharpCompleto2020.Capitulo4
{
    class Aluno
    {
        public string Nome;
        public List<double> Notas = new List<double>();
        private double notaFinal;
        public double NotaFim
        {
            get { foreach (double nota in Notas) { notaFinal += nota; } return notaFinal; }
            set { notaFinal = value; }
        }
        /*
        public double NotaFinal()
        {
            double _ = 0;
            foreach (double nota in Notas)
            {
                _ += nota;
            }
            return _;
        }
        */
        public bool Aprovado()
        {
            if (this.NotaFim >= 60)
                return true;
            else
                return false;
        }
        public double NotaRestante()
        {
            if (Aprovado())
                return 0;
            else
                return 60 - this.NotaFim;
        }
    }
}
