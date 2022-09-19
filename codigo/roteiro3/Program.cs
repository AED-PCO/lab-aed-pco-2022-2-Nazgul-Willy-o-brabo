// See https://aka.ms/new-console-template for more information
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
static void atv01()
{


    Console.Write("\nProgram for sorting a numeric array using Merge Sorting");
    Console.Write("\n\nEnter number of elements: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[max];
    for (int i = 0; i < max; i++)
    {
        Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Input int array : ");
    Console.Write("\n");
    for (int k = 0; k < max; k++)
    {
        Console.Write(numbers[k] + " ");
        Console.Write("\n");
    }
    Console.WriteLine("MergeSort By Recursive Method");
    SortMerge(numbers, 0, max - 1);
    for (int i = 0; i < max; i++)
        Console.WriteLine(numbers[i]);
    Console.ReadLine();


}
static void MainMerge(int[] numbers, int left, int mid, int right)
{
    int[] temp = new int[25];
    int i, eol, num, pos;
    eol = (mid - 1);
    pos = left;
    num = (right - left + 1);

    while ((left <= eol) && (mid <= right))
    {
        if (numbers[left] <= numbers[mid])
            temp[pos++] = numbers[left++];
        else
            temp[pos++] = numbers[mid++];
    }
    while (left <= eol)
        temp[pos++] = numbers[left++];
    while (mid <= right)
        temp[pos++] = numbers[mid++];
    for (i = 0; i < num; i++)
    {
        numbers[right] = temp[right];
        right--;
    }
}
static void SortMerge(int[] numbers, int left, int right)
{
    int mid;
    if (right > left)
    {
        mid = (right + left) / 2;
        SortMerge(numbers, left, mid);
        SortMerge(numbers, (mid + 1), right);
        MainMerge(numbers, left, (mid + 1), right);
    }
}

static void atv02() { }
static void atv03()
{
}
static void atv04()
{
    Console.WriteLine("Pesquisa binaria sem pos\ndigite um numero");
    int cont = 0;
    int num = int.Parse(Console.ReadLine());
    int[] vetor = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
    int inicio = vetor[0];
    int fim = vetor.Length - 1;
    Console.WriteLine(pesquisa(num, vetor, inicio, fim, cont));
    Console.WriteLine("contador em {0}", cont);
}
static int pesquisa(int num, int[] vetor, int inicio, int fim, int cont)
{
    int meio = (inicio + fim) / 2;
    if (inicio > fim)
    {
        cont++;
        return -1;
    }
    else if (vetor[meio] == num)
    {
        cont++;
        return vetor[meio];
    }
    else if (num > vetor[meio])
    {
        return pesquisa(num, vetor, meio + 1, fim, cont++);
    }
    else
        return pesquisa(num, vetor, inicio, meio - 1, cont++);
}