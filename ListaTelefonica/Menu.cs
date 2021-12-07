using System;
using ListaTelefonica.Entities;
using ListaTelefonica.Execeptions;
using System.Collections.Generic;


namespace ListaTelefonica 
{
    class Menu
    {
        private CrudContatos crud;
        private List<Contato> lista;

        public Menu()
        {
            crud = new CrudContatos();
            lista = new List<Contato>();
        }
        public void MenuIncluir(Contato contato)
        {
            Console.WriteLine();
            Console.WriteLine("Novo Contato");
            Console.Write("Codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(nome) && String.IsNullOrWhiteSpace(telefone) && String.IsNullOrWhiteSpace(codigo + ""))
            {
                throw new DomainExeception("Os Campos Obrigatorios não foram preenchidos corretamente !");
            }
            else
            {
                contato = new Contato(nome, telefone, codigo);
                crud.AdicionarContato(contato);
                Console.Clear();
            }
        }
        public void MenuRemover()
        {
            Console.Write("Informe o codigo do contato a ser Removido");
            int codigoProcurado = int.Parse(Console.ReadLine());

            crud.RemoverContato(codigoProcurado);
            Console.Clear();
            Console.WriteLine("Removido Com Sucesso !");
        }
        public void MenuEditar()
        {
            lista = crud.MenuLista();
            Console.Write("Informe o codigo do contato a ser Editado: ");
            int codigoProcurado = int.Parse(Console.ReadLine());
            foreach(Contato c in lista)
            {
                if (!(c._codigo != codigoProcurado))
                {
                    Console.WriteLine("Informe os novos dados do contato");
                    Console.Write("Nome: ");
                    c._nome = Console.ReadLine();
                    Console.Write("Telefone: ");
                    c._telefone = Console.ReadLine();

                    crud.EditarContato(c);
                    Console.Clear();
                    Console.WriteLine("Editado Com Sucesso !");
                }
                Console.WriteLine("Valor informado não existe");
            } 
        }
        public void MenuListar()
        {
            lista = crud.MenuLista();
            foreach(Contato c in lista)
            {
                Console.WriteLine(c);
            }
        }
    }
}
