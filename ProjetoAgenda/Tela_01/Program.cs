using System;

namespace Tela_01
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyCircularList list = new DoublyCircularList();
            int menu;
            while (true)
            {
                Console.WriteLine("======== AGENDA TELEFONICA ========");
                Console.WriteLine("[1] Adicionar um novo contato");
                Console.WriteLine("[2] Remover um contato");
                Console.WriteLine("[3] Atualizar contato");
                Console.WriteLine("[4] Recuperar contato");
                Console.WriteLine("[5] Ordenar");
                Console.WriteLine("[6] Listar contatos");
                Console.WriteLine("[7] Salvar em Arquivo");
                Console.WriteLine("[8] Navegacao");
                Console.WriteLine("[0] Sair");
                Console.WriteLine("==================================");
                Console.WriteLine("=> Opcao: ");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (menu == 1)
                {
                    string name, phone, email;

                    Console.WriteLine("Novo Contato:");

                    Console.WriteLine("Nome: ");
                    name = Console.ReadLine();

                    Console.WriteLine("Telefone: ");
                    phone = Console.ReadLine();

                    Console.WriteLine("Email: ");
                    email = Console.ReadLine();

                    list.Add(new Contact(name, phone, email));
                }
                else if (menu == 2)
                {
                    string email;
                    Console.WriteLine("Digite o email: ");
                    email = Console.ReadLine();
                    Console.WriteLine("Procurando contato para deletar.");

                    if (list.DeleteNode(email))
                    {
                        Console.WriteLine("Contato encontrado e deletado com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível deletar o contato");
                    }
                }
                else if (menu == 3)
                {
                    string email;
                    Console.WriteLine("Digite o email: ");
                    email = Console.ReadLine();
                    Console.WriteLine("Procurando contato para atualizar.");

                    Contact contact = list.Find(email);

                    if (contact != null)
                    {
                        Console.WriteLine("Editando usuário.");
                        Console.WriteLine(contact);

                        Console.WriteLine("Nome: ");
                        contact.name = Console.ReadLine();

                        Console.WriteLine("Telefone: ");
                        contact.phone = Console.ReadLine();

                        Console.WriteLine("Email: ");
                        contact.email = Console.ReadLine();

                        Console.WriteLine("Contato atualizado com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível carregar o arquivo.");
                    }
                }
                else if (menu == 4)
                {
                    Console.WriteLine("Recuperando do arquivo...");

                    if (list.LoadFile("arquivo.txt"))
                    {
                        Console.WriteLine("Arquivo carregado com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível carregar o arquivo.");
                    }
                }
                else if (menu == 5)
                {
                    int sortOption;

                    Console.WriteLine("Escolha a opção de ordenação.");
                    Console.WriteLine("[1] Por Nome");
                    Console.WriteLine("[2] Por Email");
                    Console.WriteLine("Opção: ");

                    sortOption = Convert.ToInt32(Console.ReadLine());
                    if (sortOption == 1)
                    {
                        list.BubbleSort("name");
                    }
                    else if (sortOption == 2)
                    {
                        list.BubbleSort("email");
                    }
                    Console.Clear();
                }
                else if (menu == 6)
                {
                    Console.WriteLine("Listando todos os contatos:");
                    list.Print();
                }
                else if (menu == 7)
                {
                    Console.WriteLine("Salvando em um arquivo...");

                    if (list.PrintFile("arquivo.txt"))
                    {
                        Console.WriteLine("Arquivo salvo com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível salvar o arquivo.");
                    }

                }
                else if (menu == 8)
                {
                    if (list.head == null)
                    {
                        Console.WriteLine("Lista vazia.");
                        return;
                    }

                    Node temp = list.head;

                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Menu Navegação:");
                        Console.WriteLine("Seta esquerda: contato anterior");
                        Console.WriteLine("Seta direita: próximo contato");
                        Console.WriteLine("Aperte qualquer outra tecla sair do menu navegação");
                        Console.WriteLine("Contato Atual:");
                        Console.WriteLine(temp.data);

                        string key = Console.ReadKey().Key.ToString();

                        if (key == "LeftArrow")
                        {
                            temp = temp.prev;
                        }
                        else if (key == "RightArrow")
                        {
                            temp = temp.next;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
