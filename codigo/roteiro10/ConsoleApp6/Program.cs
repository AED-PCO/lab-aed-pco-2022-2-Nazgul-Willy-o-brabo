using ConsoleApp6;
using dinamico;

string repet;
do
{
    Console.WriteLine("Estrutura de dados:");
    Console.WriteLine("Selecione a atividade: \n1 = lista\n2 = pilha\n3 = fila");
    int op = int.Parse(Console.ReadLine());
    Console.Clear();
    if (op == 1)
    {
        fila();
    }
    else if (op == 2)
    {
        pilha();
    }
    else if (op == 3) { lista(); }
    else
    {
        Console.WriteLine("Atividade inexistente");
    }

    static void fila()
    {
        string op;
        string rep;
        Elemento primeiro = new Elemento();
        Elemento ultimo = primeiro;

        Console.WriteLine("--FILA--\n\n");
        do
        {
            Console.WriteLine("Digite uma operação:\nin = inserir\nre = remover\nvi = visualizar\n");
            op = Console.ReadLine().ToLower();
            if (op == "in")
            {
                Fila.InserirFila(ref ultimo);
            }
            else if (op == "re")
            {
                Fila.RemoveFila(ref primeiro, ref ultimo);
            }
            else if (op == "vi")
            {
                Fila.MostrarFila(ref primeiro, ref ultimo);
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
            Console.WriteLine("\nOutra operaçao\ns = sim\nn = não\n");
            rep = Console.ReadLine().ToLower();
            Console.Clear();
        }
        while (rep == "s");
    }
    static void pilha()
    {
        Elemento primeiro = new Elemento();
        Elemento ultimo = primeiro;
        string op;
        string rep;
        Console.WriteLine("--PILHA--\n\n");
        do
        {
            Console.WriteLine("Digite uma operação:\nin = inserir\nre = remover\nvi = visualizar\n");
            op = Console.ReadLine().ToLower();
            if (op == "in")
            {
                Pilha.InserirPilha(ref ultimo);
            }
            else if (op == "re")
            {
                Pilha.RemoverPilha(ref primeiro, ref ultimo);
            }
            else if (op == "vi")
            {
                Fila.MostrarFila(ref primeiro, ref ultimo);
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
            Console.WriteLine("\nOutra operaçao\ns = sim\nn = não\n");
            rep = Console.ReadLine().ToLower();
            Console.Clear();
        }
        while (rep == "s");
    }
    static void lista()
    {
        string op;
        string rep;
        Elemento primeiro = new Elemento();
        Elemento ultimo = primeiro;

        Console.WriteLine("--LISTA--\n\n");
        do
        {
            Console.WriteLine("Digite uma operação:\nin = inserir\nre = remover\nvi = visualizar\n");
            op = Console.ReadLine().ToLower();
            if (op == "in")
            {
                Lista.InserirLista();
            }
            else if (op == "re")
            {

            }
            else if (op == "vi")
            {

            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
            Console.WriteLine("\nOutra operaçao\ns = sim\nn = não\n");
            rep = Console.ReadLine().ToLower();
            Console.Clear();
        }
        while (rep == "s");
    }
    Console.WriteLine("Deseja escolher uma nova atividade?\ns= sim ou n= nao");
    repet = Console.ReadLine().ToLower();
    Console.Clear();
} while (repet == "s");
Console.Clear();

