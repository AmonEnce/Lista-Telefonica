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
                Contato contato = new Contato();
                Menu menu = new Menu();

                Console.WriteLine("------LISTA TELEFONICA------");
                menu.MenuIncluir(contato);
                char incluir = 'c';

                while (incluir == 'c')
                {
                    Console.WriteLine();
                    Console.WriteLine("Para continuar ou sair informe uma das opções abaixo");
                    Console.WriteLine("E - Editar / R - Remover / I - incluir / L - Lista de Contatos / S - Sair");
                    char resposta = char.Parse(Console.ReadLine().ToUpper());
                    Console.WriteLine();

                    switch (resposta)
                    {
                        case 'E':
                            menu.MenuEditar();
                            break;
                        case 'R':
                            menu.MenuRemover();
                            break;
                        case 'I':
                            menu.MenuIncluir(contato);
                            break;
                        case 'L':
                            menu.MenuListar();
                            break;
                        case 'S':
                            incluir = 'S';
                            Console.WriteLine("Finalizando o programa ! Até a proxima ");
                            break;
                    }
                }
            }
            catch (DomainExeception erro)
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
