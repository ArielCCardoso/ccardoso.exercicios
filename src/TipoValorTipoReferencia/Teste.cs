using System;
using System.Collections.Generic;
using System.Text;

namespace TipoValorTipoReferencia
{
    class Teste
    {
        public string Nome { get; private set; }
        public string Cidade { get; private set; }
        private double saldo;
        public double Saldo { get { return this.saldo; } set { saldo = value; } }

        public Teste(string nome, string cidade)
        {
            Nome = nome;
            Cidade = cidade;
        }
        public Teste(string nome, string cidade, double saldo) : this (nome, cidade)
        {
            this.saldo = saldo;
        }

        public override string ToString()
        {
            return $"{Nome}, cidade: {Cidade}, Saldo: R$ {saldo}...";
        }
        public void Set(string a, string b, double c)
        {
            Nome = a;
            Cidade = b;
            Saldo = c;
        }
    }
}
