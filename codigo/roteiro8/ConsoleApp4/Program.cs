using System;
using System.Runtime.Intrinsics.Arm;

string repet;
do
{
    Console.WriteLine("Estrutura de dados:");
    Console.WriteLine("Selecione a atividade: \n1 = lista\n2 = pilha\n3 = fila");
    int op = int.Parse(Console.ReadLine());
    if (op == 1) { atv01(); }
    else if (op == 2) { atv02(); }
    else if (op == 3) { atv03(); }
    else
    {
        Console.WriteLine("Atividade inexistente");
    }
    static void atv01()
    {
        string op;
        string rep;
        Console.WriteLine("--FILA--\n\n");
        int[] fila = new int[5];
        int Ref = 0;
        do
        {
            Console.WriteLine("Digite uma operação:\nin = inserir\nre = remover\nvi = visualizar\n");
            op = Console.ReadLine().ToLower();
            if (op == "in")
            {
                inserirFila(fila, ref Ref);
            }
            else if (op == "re")
            {
                removerFila(fila, ref Ref);
            }
            else if (op == "vi")
            {
                visualizarFila(fila, ref Ref);
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
            Console.WriteLine("\nOutra operaçao\ns = sim\nn = não\n");
            rep = Console.ReadLine().ToLower();
        }
        while (rep == "s");
    }
    static void inserirFila(int[] fila, ref int Ref)
    {
        if (Ref < fila.Length)
            while (Ref < fila.Length)
            {
                Console.Write("Digite o valor a ser inserido na posição {0}: ", Ref + 1);
                fila[Ref] = int.Parse(Console.ReadLine());
                Ref++;
            }
        else
            Console.WriteLine("Sua fila está cheia, utilize outra operação\n");
    }
    static void removerFila(int[] fila, ref int Ref)
    {
        int aux = fila[0];
        for (int i = 0; i < fila.Length - 1; i++)
        {
            fila[i] = fila[i + 1];
        }
        Ref--;
        Console.WriteLine("Removido com sucesso o primeiro item : {0}", aux);
    }
    static void visualizarFila(int[] fila, ref int Ref)
    {
        Console.WriteLine("Sua lista atualmente possui os seguintes numeros");
        for (int i = 0; i < fila.Length; i++)
        {
            if (i < Ref)
            {
                Console.WriteLine("Posição: {0} Numero: {1}", i + 1, fila[i]);
            }
            else
            {
                Console.WriteLine("Posição {0} vazia", i + 1);
            }
        }
    }
    static void atv02()
    {
        string op;
        string rep;
        Console.WriteLine("--PILHA--\n\n");
        int[] fila = new int[5];
        int Ref = 0;
        do
        {
            Console.WriteLine("Digite uma operação:\nin = inserir\nre = remover\nvi = visualizar\n");
            op = Console.ReadLine().ToLower();
            if (op == "in")
            {
                inserirFila(fila, ref Ref);
            }
            else if (op == "re")
            {
                removerPilha(fila, ref Ref);
            }
            else if (op == "vi")
            {
                visualizarFila(fila, ref Ref);
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
            Console.WriteLine("\nOutra operaçao\ns = sim\nn = não\n");
            rep = Console.ReadLine().ToLower();
        }
        while (rep == "s");
    }
    static void removerPilha(int[] fila, ref int Ref)
    {
        int aux = fila[Ref - 1];
        Ref--;
        Console.WriteLine("Removido com sucesso o ultimo item disponivel da pilha : {0}", aux);
    }
    static void atv03()
    {
        string op;
        string rep;
        Console.WriteLine("--FILA--\n\n");
        int[] fila = new int[5];
        int Ref = 0;
        do
        {
            Console.WriteLine("Digite uma operação:\nin = inserir\nre = remover\nvi = visualizar\n");
            op = Console.ReadLine().ToLower();
            if (op == "in")
            {
                inserirLista(fila, ref Ref);
            }
            else if (op == "re")
            {
                removerLista(fila, ref Ref);
            }
            else if (op == "vi")
            {
                visualizarFila(fila, ref Ref);
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
            Console.WriteLine("\nOutra operaçao\ns = sim\nn = não\n");
            rep = Console.ReadLine().ToLower();
        }
        while (rep == "s");
    }
    static void inserirLista(int[] fila, ref int Ref)
    {
        if (Ref < fila.Length)
        {
            char Rep;
            int num; int pos = 0;
            do
            {
                Console.Write("Deseja selecionar um posição? S/N  ");
                char Op = char.Parse(Console.ReadLine().ToLower());
                if (Op == 's')
                {
                    do
                    {
                        Console.WriteLine("\nSelecione uma posição entre 1 e {0}", fila.Length);
                        pos = int.Parse(Console.ReadLine());
                    } while (pos < 1 || pos > fila.Length);
                    if (pos > Ref)
                    {
                        Console.WriteLine("Sua posição é maior que o valor de referencia, ajustamos a posição");
                        pos = Ref;
                    }
                    Console.Write("\nDigite o numero para inserir na posição {0} da lista: ", pos);
                    num = int.Parse(Console.ReadLine());
                    if (pos == 0 && Ref == 0)
                    { fila[0] = num; }
                    else
                    {
                        for (int i = Ref; i > pos - 1; i--)
                        {
                            fila[i] = fila[i - 1];
                        }
                        fila[pos - 1] = num;
                    }
                    Ref++;
                }
                else
                {
                    Console.Write("\nDigite o numero para inserir na posição {0} da lista: ", Ref + 1);
                    num = int.Parse(Console.ReadLine());
                    fila[Ref] = num;
                    Ref++;
                }
                Console.Write("\nDeseja adicionar outro numero? (S)im / (N)ão  ");
                Rep = char.Parse(Console.ReadLine().ToLower());
                Console.WriteLine(Ref);
            } while (Rep == 's' && Ref < fila.Length);
        }
        else
        {
            Console.WriteLine("Lista cheia! Selecione outra operação!");
        }
    }
    static void removerLista(int[] fila, ref int Ref)
    {
        if (Ref > 0)
        {
            int aux;
            char Op;
            if (Ref > 0)
            {
                Console.Write("Selecione a posição que deseja remover (1-5): ");
                int rem = int.Parse(Console.ReadLine());
                if (rem < 1 || rem > Ref)
                {
                    Console.WriteLine("Valor invalido!");
                }
                int auxR = fila[rem - 1];
                for (int i = rem - 1; i < fila.Length - 1; i++)
                {
                    fila[i] = fila[i + 1];
                }
                Ref--;
                Console.WriteLine("Removido com sucesso o item da posição: {0}; item {1}", rem, auxR);
            }
            else
                Console.WriteLine("Fila vazia, Selecione outra operação\n");
        }
    }
    Console.WriteLine("Deseja escolher uma nova atividade?\ns= sim ou n= nao");
    repet = Console.ReadLine().ToLower();
} while (repet == "s");
Console.Clear();
