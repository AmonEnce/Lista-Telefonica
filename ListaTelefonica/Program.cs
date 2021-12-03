using System;
using ListaTelefonica.Entities;
using ListaTelefonica.Execeptions;
namespace ListaTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ListaDeContatos listaTelefonica = new ListaDeContatos();

                Console.WriteLine("------LISTA TELEFONICA------");
                Console.WriteLine("Deseja incluir um novo contato(C - Continuar)");
                char incluir = char.Parse(Console.ReadLine());

                while (incluir == 'C' || incluir == 'c')
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
                        Contato contato = new Contato(nome, telefone, codigo);
                        listaTelefonica.AdicionarContato(contato);
                    }


                    Console.WriteLine();
                    Console.WriteLine("Para continuar ou sair informe uma das opções abaixo");
                    Console.WriteLine("E - Editar / R - Remover / I - incluir / L - Lista de Contatos / S - Sair");
                    char resposta = char.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (resposta == 'E' || resposta == 'e')
                    {
                        Console.Write("Informe o codigo do contato a ser Editado: ");
                        int codigoProcurado = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe os novos dados do contato");
                        Console.Write("Nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Telefone: ");
                        telefone = Console.ReadLine();

                        listaTelefonica.EditarContato(codigoProcurado, nome, telefone);
                        Console.WriteLine("Editado Com Sucesso !");
                    }
                    else if (resposta == 'R' || resposta == 'r')
                    {
                        Console.Write("Informe o codigo do contato a ser Removido");
                        int codigoProcurado = int.Parse(Console.ReadLine());

                        listaTelefonica.RemoverContato(codigoProcurado);
                        Console.WriteLine("Removido Com Sucesso !");
                    }
                    else if (resposta == 'N' || resposta == 'n')
                    {
                        incluir = resposta;
                    }
                    else if (resposta == 'L' || resposta == 'l')
                    {
                        foreach (Contato print in listaTelefonica)
                        {
                            Console.WriteLine(print);
                        }
                    }
                    else
                    {

                    }
                }
            }
            catch(DomainExeception erro)
            {
                Console.WriteLine(erro.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor informado não é valido para esse campo !");
            }
        }
    }
}
