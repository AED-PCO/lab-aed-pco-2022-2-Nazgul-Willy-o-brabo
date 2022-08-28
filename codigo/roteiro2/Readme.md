using System;

namespace atv_recursiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("selecione a atividade: ");
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
                case 7:
                    atv07();
                    break;
            }
        }
        static void atv01()
        {
            Console.WriteLine("Fatorial de um numero usando recursividade");
            Console.Write("digite um numero para saber o fatorial: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num = fat(num));
        }
        static int fat(int x)
        {
            if (x == 1)
                return (1);
            else
                return x * fat(x - 1);
        }
        static void atv02()
        {
            Console.WriteLine("Multiplicação de dois numeros usando recursividade");
            Console.Write("digite o numero #1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("digite o numero #2: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = mult(num1, num2);
            Console.WriteLine(resultado);
        }
        static int mult(int x, int y)
        {
            /*          int aux = (-1);
                      if (y < 0)
                      {
                          x = x * aux;
                          return x + mult(+x, y - 1);
                      }
                      if (y > 0)
                          return x + mult(+x, y - 1);
                      else
                          return (0);
                   */
            int aux = 0, aux1 = 0, aux2 = 0;
            if (x < 0)
            {
                x = x * (-1);
                aux = (-1);
            }
            if (y < 0)
            {
                x = x * (-1);
                aux1 = (-1);
            }
            if (y == 0)
            {
                return 0;
            }
            aux2 = x + mult(x, y - 1);

            if ((aux == (-1)) && (aux2 == (-1)))
            {
                return aux2;
            }
            else if (aux1 == (-1))
            {
                return (aux2 * aux);
            }
            else if (aux2 == (-1))
            {
                return (aux2 * aux1);
            }
            else
                return aux2;
        }
        static void atv03()
        {
            Console.WriteLine("potenciação de dois numeros usando recursividade");
            Console.Write("digite a base: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("digite a potencia: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = pot(num1, num2);
            Console.WriteLine(resultado);
        }
        static int pot(int x, int y)
        {
            if (y == 1)
                return (0);
            else
                return x * pot(x, y - 1);
        }
        static void atv04()
        {

            Console.WriteLine("digite uma frase e uma letra para saber quantas vezes ela se repete");
            Console.Write("digite a frase: ");
            string frase = Console.ReadLine();
            Console.Write("*MINUSCULA* digite uma letra: ");
            char letra = Console.ReadKey().KeyChar;
            frase.ToLower();
            int n = texto(frase, letra);
            Console.WriteLine("\n" + n);
        }
        static int texto(string frase, char letra)
        {
            int n = 0;
            if (frase.Length < 1)
                return 0;
            else
            {
                if (frase[0] == letra)
                {
                    return texto(frase.Substring(1), letra) + n + 1; ;
                }
                else
                    return texto(frase.Substring(1), letra);
            }
        }

        static void atv05()
        {
            int[] num = new int[10];
            Console.WriteLine("metodo recursivo para somar pares de vetor");
            levetor(num);
            Console.WriteLine("a soma é: {0}", soma(num, 10));
        }

        static void levetor(int[] vetor)
        {
            Console.WriteLine("*SÓ POSITIVOS* digite o numero: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("posição {0}: ", i + 1);
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] < 0)
                {
                    Console.WriteLine("só numeros positivos");
                    return;
                }
            }
        }
        static int soma(int[] vetor, int aux)
        {
            if (aux == 0)
                return (0);
            else
            {
                if (vetor[aux - 1] % 2 == 0)
                {
                    return vetor[aux - 1] + soma(vetor, aux - 1);
                }
                else
                    return soma(vetor, aux - 1);
            }
        }
        static void atv06()
        {
            Console.WriteLine("frase sem vogal >:)");
            Console.Write("digite a frase: ");
            string frase = Console.ReadLine();
            semvogal(frase,0);
        }
        static string semvogal(string frase, int pos)
        {
            if (pos==frase.Length)
                return "" ;
            else
            {
                string sub="";
                if (frase[0] != 'a' || frase[0] != 'A' || frase[0] != 'e' || frase[0] != 'E' || frase[0] != 'i' || frase[0] != 'I' || frase[0] != 'O' || frase[0] != 'o' || frase[0] != 'u' || frase[0] != 'U')
                    sub = frase.ToString();
          //          sub = (String)frase(pos);
                    return sub + semvogal(frase,pos+1);
            }
 
        }

        static void atv07(){
                Console.WriteLine("fibonnaci");
                Console.WriteLine("entre com um valor");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("o valor de fib de {0} é {1}",n,fib(n));            
        }
        static int fib(int x){
            if(x==0)
                return 0;
            else if(x==1)
                return 1;
            else
                return fib(x-1)+fib(x-2);

        }
    }
}
