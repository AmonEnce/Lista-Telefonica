using System;
using System.Collections;


namespace ListaTelefonica.Entities
{
    class Contato : IEntidade
    {
        public string _nome { get; set; }
        public string _telefone { get; set; }
        public int _codigo { get; set; }

        public Contato()
        {
        }
        public Contato(string nome, string telefone, int codigo)
        {
            _nome = nome;
            _telefone = telefone;
            _codigo = codigo;
        }
        public override string ToString()
        {
            return "Codigo: " + _codigo + " Nome :" + _nome + " Telefone: " + _telefone;
        }
    }
}
