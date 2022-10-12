using System;
using System.Drawing;
using System.Xml.Linq;

Console.WriteLine("selecione a atv");
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
    case 5:
        atv05();
        break;
    case 6:
        atv06();
        break;
}

static void atv01()
{
    Console.WriteLine("bubble");
    int[] vetor = new int[10] { 90, 00, 80, 10, 70, 20, 60, 30, 50, 40 };
    int Ref = vetor.Length;
    bubble(vetor, Ref);
    for (int i = 0; i <= vetor.Length; i++)
    {
        Console.WriteLine(vetor[i]);
    }
}
static void bubble(int[] Vet, int Ref)
{
    int temp = 0;
    for (int i = 0; i < Ref; i++)
    {
        for (int k = 0; k < Ref - 1; k++)
        {
            if (Vet[k] > Vet[k + 1])
            {
                temp = Vet[k + 1];
                Vet[k + 1] = Vet[k];
                Vet[k] = temp;
            }
        }
        Ref--;
    }
}
static void atv02()
{
    Console.WriteLine("Selection Sort");
    int[] vetor = new int[10] { 90, 80, 00, 10, 70, 20, 60, 30, 50, 40 };
    selection(vetor);
    for (int j = 0; j < vetor.Length; j++)
    {
        Console.WriteLine(vetor[j]);
    }
}
static void selection(int[] vetor)
{
    int temp = 0;
    for (int i = 0; i < vetor.Length - 1; i++)
    {
        int menor = i;
        for (int k = (i + 1); k < vetor.Length; k++)
        {
            if (vetor[k] < vetor[menor])
                menor = k;
        }
        temp = vetor[menor];
        vetor[menor] = vetor[i];
        vetor[i] = temp;
    }
}
static void atv03()
{
    Console.WriteLine("insection sort");
    int[] vetor = new int[10] { 90, 80, 00, 10, 70, 20, 60, 30, 50, 40 };
    insert(vetor);
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine(vetor[i]);
    }
}
static void insert(int[] vetor)
{
    for (int i = 0; i < vetor.Length - 1; i++)
    {
        for (int j = i + 1; j > 0; j--)
        {
            if (vetor[j - 1] > vetor[j])
            {
                int temp = vetor[j - 1];
                vetor[j - 1] = vetor[j];
                vetor[j] = temp;
            }
        }
    }
}
static void atv04()
{
    Console.WriteLine("quick");
    int[] vetor = new int[10] { 90, 80, 00, 10, 70, 20, 60, 30, 50, 40 };
    quick(vetor, 0, vetor.Length - 1);
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine(vetor[i]);
    }
}
static void quick(int[] vetor, int inicio, int fim)
{
    if (inicio < fim)
    {
        int pivo = particao(vetor, inicio, fim);

        if (pivo > 1)
        {
            quick(vetor, inicio, pivo - 1);
        }
        if (pivo + 1 < fim)
        {
            quick(vetor, pivo + 1, fim);
        }
    }
}
static int particao(int[] vetor, int inicio, int fim)
{
    int pivo = vetor[inicio];
    while (true)
    {
        while (vetor[inicio] < pivo)
        {
            inicio++;
        }
        while (vetor[fim] > pivo)
        {
            fim--;
        }
        if (inicio < fim)
        {
            if (vetor[inicio] == vetor[fim]) return fim;
            int temp = vetor[inicio];
            vetor[inicio] = vetor[fim];
            vetor[fim] = temp;
        }
        else
            return fim;
    }
}
static void atv05()
{
    Console.WriteLine("Shell");
    int[] vetor = new int[10] { 90, 80, 00, 10, 70, 20, 60, 30, 50, 40 };
    shell(vetor);
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine(vetor[i]);
    }
}
static void shell(int[] vetor)
{
    {
        int i, j, Ref, temp;
        Ref = 3;
        while (Ref > 0)
        {
            for (i = 0; i < vetor.Length; i++)
            {
                j = i;
                temp = vetor[i];
                while ((j >= Ref) && (vetor[j - Ref] > temp))
                {
                    vetor[j] = vetor[j - Ref];
                    j = j - Ref;
                }
                vetor[j] = temp;
            }
            if (Ref / 2 != 0)
                Ref = Ref / 2;
            else if (Ref == 1)
                Ref = 0;
            else
                Ref = 1;
        }
    }
}
static void atv06()
{
    Console.WriteLine("contagem");
    int[] vetor = new int[10] { 90, 80, 00, 10, 70, 20, 60, 30, 50, 40 };
    contagem(vetor);
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine(vetor[i]);
    }
}
static int valorMaximo(int[] vetor)
{
    var maxVal = vetor[0];
    for (int i = 1; i < vetor.Length; i++)
        if (vetor[i] > maxVal)
            maxVal = vetor[i];
    return maxVal;
}
static void contagem(int[] vetor)
{
    var maximoElementos = valorMaximo(vetor);
    var ocorrencias = new int[maximoElementos + 1];
    for (int i = 0; i < maximoElementos + 1; i++)
    {
        ocorrencias[i] = 0;
    }
    for (int i = 0; i < vetor.Length; i++)
    {
        ocorrencias[vetor[i]]++;
    }
    for (int i = 0, j = 0; i <= maximoElementos; i++)
    {
        while (ocorrencias[i] > 0)
        {
            vetor[j] = i;
            j++;
            ocorrencias[i]--;
        }
    }
}