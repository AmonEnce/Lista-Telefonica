using System;
using System.Collections;
using System.Collections.Generic;
using ListaTelefonica.Execeptions;

namespace ListaTelefonica.Entities
{
    class ListaDeContatos : IEnumerable<Contato>
    {
        public List<Contato> contatos = new List<Contato>();

        public void AdicionarContato(Contato contato)
        { 
            contatos.Add(contato);
        }

        public void RemoverContato(int codigo)
        {
            if (codigo <= 0)
            {
                throw new DomainExeception("Codigo invalido !");
            }
            contatos.RemoveAt(codigo - 1);
        }

        public void EditarContato(int codigoProcurado, string nome, string telefone)
        {
            codigoProcurado -= 1;
            contatos[codigoProcurado]._nome = nome;
            contatos[codigoProcurado]._telefone = telefone;
        }

        public IEnumerator<Contato> GetEnumerator()
        {
            return contatos.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
