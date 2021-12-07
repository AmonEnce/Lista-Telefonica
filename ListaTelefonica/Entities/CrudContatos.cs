using System;
using System.Collections;
using System.Collections.Generic;

namespace ListaTelefonica.Entities
{
    class CrudContatos : ControladorLista<Contato>, IEnumerable
    {
        List<Contato> contatos = new List<Contato>();
        public override void AdicionarContato(Contato obj)
        {
            contatos.Add(obj);
        }
        public override void EditarContato(Contato obj)
        {
            foreach (Contato c in contatos)
            {
                c._nome = obj._nome;
                c._telefone = obj._telefone;
            }
        }
        public override void RemoverContato(int codigo)
        {
            contatos.RemoveAt(contatos.FindIndex(c => c._codigo.Equals(codigo)));
        }
        public override List<Contato> MenuLista()
        {
            return contatos;
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
