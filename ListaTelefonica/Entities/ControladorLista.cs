using System.Collections.Generic;
namespace ListaTelefonica.Entities
{
    public abstract class ControladorLista<T> where T : IEntidade
    {
        public virtual void AdicionarContato(T obj)
        { 
        }
        public virtual void RemoverContato(int codigo)
        {
        }
        public virtual void EditarContato(T obj)
        {
        }
        public virtual List<T> MenuLista()
        {
            return null;
        }
    }
}
