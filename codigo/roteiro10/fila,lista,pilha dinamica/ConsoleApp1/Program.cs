using ConsoleApp1;
using System;
using System.Runtime.Intrinsics.Arm;


string repet;
do
{
    Menu menu = new Menu();

    Console.WriteLine("Estrutura de dados:");
    Console.WriteLine("Selecione a atividade: \n1 = fila\n2 = pilha\n3 = lista");
    int op = int.Parse(Console.ReadLine());
    if (op == 1)
    {
        menu.menuFila();
    }
    else if (op == 2)
    {
        menu.menuPilha();
    }
    else if (op == 3)
    {
        menu.menuLista();
    }
    else
    {
        Console.WriteLine("Atividade inexistente");
    }







    Console.WriteLine("Deseja escolher uma nova atividade?\ns= sim ou n= nao");
    repet = Console.ReadLine().ToLower();
} while (repet == "s");
Console.Clear();
