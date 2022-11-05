using System.IO;

Console.Write("--PROVA--\nselecione a atividade: ");
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
}
static void atv01()
{
    Console.WriteLine("Projetando um arquivo, onde, o usuario compara o que ele escreveu com oq está dentro do arquivo");
    Console.WriteLine("Digite um numero ai mané");
    int op = int.Parse(Console.ReadLine());
    if (op == 12321)
    {
        StreamReader easter = new StreamReader("C:\\Users\\willy\\source\\repos\\prova\\textoAtv01\\Atv01.txt");
        string line = easter.ReadLine();
        while (line != null)
        {
            Console.WriteLine(line);
            line = easter.ReadLine();
        }
        easter.Close();
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("atv normal");
        StreamReader sr = new StreamReader("C:\\Users\\willy\\source\\repos\\prova\\textoAtv01\\Atv02.txt");
        Console.Write("Digite um texto: ");
        string texto = Console.ReadLine();
        string linha = sr.ReadLine();
        if(texto == linha)
        {
            Console.WriteLine("está certo               /igual");
        }
        else
        {
            Console.WriteLine("Está errado          /diferente");
        }
        sr.Close();
        Console.ReadLine();
    }
}
static void atv02() {
    Console.WriteLine("Dado o codigo a seguir: veja seu retorno");
    Console.WriteLine(funcRec1(6));
}
static int funcRec1(int a) {
    if (a <= 1)
    return 0;
    else { 
        return funcRec1((a - 2) + 5);
    }
}
static void atv03() { 
    Console.WriteLine("inverso de um arquivo e.e");
    StreamReader sr = new StreamReader("C:\\Users\\willy\\source\\repos\\prova\\textoAtv01\\Atv02.txt");
    string linha = sr.ReadLine();
    string inverso = new string(linha.Reverse().ToArray());
    Console.WriteLine(inverso);
}
static void atv04() {
    Console.WriteLine("gerador de cpf");     // alt+shift+. para selecionar varios elementos iguais e altera-los
    int[] Cpf = new int[11];
    int dez=0; int onze = 0; int k = 0;
    while( k < 100){ 
    Cpf = random();
    dez = Decimo(Cpf);
    Cpf[9] = dez;
    onze = Onze(Cpf);
    Cpf[10] = onze;
    for (int i = 0; i < Cpf.Length; i++) {
        Console.Write(Cpf[i]);   
    }
        Console.Write(" ");
        k++;
}
}
static int [] random()
{
    int min = 0, max = 9;
    int[] vetor = new int[11];
    Random ran = new Random();
    for (int i = 0; i <= vetor.Length-1; i++)
    {
        vetor[i] = ran.Next(min, max);
    }
    return vetor;
}
static int Decimo(int [] vet)
{
    int final = 0;
    int Ref = 10;
    int n = 0;
    for (int i = 0; i < 9; i++)
    {
        n += vet[i] * Ref;
        Ref--;
    }
    int resto = n % 11;
    if (resto == 0 || resto == 1)
    {
        final = 0;
    }
    else
        final = 11 - resto;
    return final;
}
static int Onze(int[] vet)
{
    int final = 0;
    int Ref = 10;
    int n = 0;
    for (int i = 1; i < 10; i++)
    {
        n += vet[i] * Ref;
        Ref--;
    }
    int resto = n % 11;
    if (resto == 0 || resto == 1)
    {
        final = 0;
    }
    else
        final = 11 - resto;
    return final;
}

static void atv05() {
    Console.WriteLine("O codigo a seguir implementa uma função recursiva, descubra qual é o retorno da mesma");
    int a = 6; int [] vet = new int [7] { 10, 5, 7, 15, 22, 9, 30 };
    Console.WriteLine(funcao(a, vet));
}
static int funcao(int a, int[] v)
{
    if (a == 1)
        return v[0];
    else
    {
        int x;
        x = funcao(a - 1, v);
        if (x > v[a - 1])
            return x;
        else
            return v[a - 1];
    }
}