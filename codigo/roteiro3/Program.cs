Console.WriteLine("selecione a atividade");
int op = int.Parse(Console.ReadLine());
switch (op)
{
    case 1:
        atv01();
        break;
    case 2:
        atv02();
        break;
    case 3:
        atv03();
        break;
    case 4:
        atv04();
        break;
}
Console.ReadKey();
Console.Clear();
static void atv01()
{
        Random rd = new Random();
        Console.WriteLine("vetores ordenados");
        int[] vetor = new int[10];
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = rd.Next(0, 1000);
        }
        ord_parcial(vetor, 0, vetor.Length - 1);            // PERGUNTAR PQ O ESQ=VETOR[0] DÁ ERRADO
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine(vetor[i]);
        }

    }
    static void ord_parcial(int[] vet, int esq, int dir)
    {
        int meio;
        if (dir > esq)
        {
            meio = (dir + esq) / 2;
            ord_parcial(vet, esq, meio);        // vetorA
            ord_parcial(vet, (meio + 1), dir);      // VetorB
            ordenacao(vet, esq, (meio + 1), dir);
        }

    }
    static void ordenacao(int[] vet, int esq, int meio, int dir)
    {
        int[] aux = new int[vet.Length];
        int meioEsq = (meio - 1);         // - PERGUNTAR PQ USANDO VARIAVEL DÁ CERTO E COLOCANDO SO A LOGICA NÃO
        int pos = esq; int num = (dir - esq + 1);
        while ((esq <= meioEsq) && (meio <= dir))
        {
            if (vet[esq] <= vet[meio])
                aux[pos++] = vet[esq++];
            else
                aux[pos++] = vet[meio++];
        }
        while (esq <= meioEsq)
            aux[pos++] = vet[esq++];
        while (meio <= dir)
            aux[pos++] = vet[meio++];
        for (int i = 0; i < num; i++)
        {
            vet[dir] = aux[dir];
            dir--;
        }
    }
static void atv02() {
    Random rd = new Random();
    Console.WriteLine("vetores ordenados by: willy Loko");
    int[] vetor = new int[10];
    for (int i = 0; i < vetor.Length; i++)
    {
        vetor[i] = rd.Next(0, 1000);
    }
    ord_parcial(vetor, 0, vetor.Length - 1);            // PERGUNTAR PQ O ESQ=VETOR[0] DÁ ERRADO
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine("seu numero na posição {0} é: {1}",i,vetor[i]);
    }
}
static void atv03()
{
    Console.WriteLine("Pesquisa binaria sem pos\ndigite um numero");
    int num = int.Parse(Console.ReadLine());
    int[] vetor = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
    int inicio = vetor[0];
    int fim = vetor.Length - 1;
    int pesq = pesquisa(num, vetor, inicio, fim);
    if (pesq != -1)
    {
        Console.WriteLine("seu numero no vetor foi encontrado {0}, na posição {1} ",pesq , vetor[pesq]);
    }
    else
        Console.WriteLine("Seu numero não foi encontrado");
}
static void atv04()
{
    Console.WriteLine("Pesquisa binaria sem pos\ndigite um numero");
    int num = int.Parse(Console.ReadLine());
    int[] vetor = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
    int inicio = vetor[0];
    int fim = vetor.Length - 1;
    int pesq = pesquisa(num, vetor, inicio, fim);
    if (pesq != -1)
    {
    Console.WriteLine("seu numero no vetor foi encontrado: ");
    }
    else
        Console.WriteLine("Seu numero não foi encontrado");
}
static int pesquisa(int num, int[] vetor, int inicio, int fim)
{
    int meio = (inicio + fim) / 2;
    if (inicio > fim)
    {
        return -1;
    }
    else if (vetor[meio] == num)
    {
        return vetor[meio];
    }
    else if (num > vetor[meio])
    {
        return pesquisa(num, vetor, meio + 1, fim);
    }
    else
        return pesquisa(num, vetor, inicio, meio - 1);
}
