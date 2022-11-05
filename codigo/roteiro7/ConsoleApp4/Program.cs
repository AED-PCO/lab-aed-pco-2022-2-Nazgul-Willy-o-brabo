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
    static void atv01() {
        string op;
        string rep;
        Console.WriteLine("Fila");
        int[] fila = new int[5];
        int Ref = 0;
        do
        {
            Console.WriteLine("Digite uma operação:\nin = inserir\nre = remover\nvi = visualizar\n");
            op = Console.ReadLine();
            if (op == "in")
            {
                inserirFila(fila, ref Ref);
                Console.WriteLine(Ref);
            }
            else if (op == "re")
            {
                //   removerFila();
            }
            else if (op == "vi")
            {
                //  visualizarFila();
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
            Console.WriteLine("Outra operaçao\ns = sim\nn = não\n");
            rep = Console.ReadLine();
        }
        while (rep == "s");
    }

    static void inserirFila(int [] fila, ref int Ref)
    {
        if (Ref < fila.Length)
            while(Ref<fila.Length)
            {
                Console.Write("Digite o valor a ser inserido na posição {0}: ", Ref + 1);
                fila[Ref] = int.Parse(Console.ReadLine());
                Ref++;
            }
        else
            Console.WriteLine("Sua fila está cheia, utilize outra operação\n");
    }
    static void RemoverFila(int[] fila, ref int Ref)
    {

    }
    static void atv02() { }
    static void atv03() { }



    Console.WriteLine("Deseja repetir essa atividade?\nsim ou nao");
    repet = Console.ReadLine();
} while (repet == "sim");
