using System;

namespace atividades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Selecione a atividade: ");
            int Op;
            Op = int.Parse(Console.ReadLine());
            switch (Op)
            {
                case 1:
                    atv01();
                    break;
                case 2:
                    atv01();
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
        }

        static void atv01() // ATIVIDADE 01
        {
            int aux;
            for (int i = 1000; i <= 9999; i++)
            {
                aux = (i / 100) + (i % 100);
                if (aux * aux == i)
                    Console.WriteLine(i);
            }
        }
        static void atv02() // ATIVIDADE 02
        {
            Console.WriteLine("digite um numero para saber se é primo ou não");
            int num = int.Parse(Console.ReadLine());
            if (primo(num))
            {
                Console.WriteLine("é primo");
            }
            else
            {
                Console.WriteLine("não é primo");
            }
            perfeitos();
        }
        static bool primo(int x)
        {
            int cont = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                    cont++;
            }
            if (cont == 2)
                return (true);
            else
                return (false);
        }
        static void perfeitos()
        {
            for (int num = 1; num <= 1000; num++)
            {
                int soma = 0;
                for (int aux = 1; aux < num; aux++)
                {
                    if (num % aux == 0)
                        soma += aux;
                    if (soma == num)
                    {
                        Console.WriteLine("o numero {0} é perfeito", num);
                        break;
                    }
                }
            }
        }

        static void atv03() // ATIVIDADE 03
        {
            int[] vetorA = new int[5]; int[] vetorB = new int[5]; int[] vetorC = new int[5]; int[] vetorD = new int[5];
            levetor(vetorA);
            levetor(vetorB);
            comparavetor(vetorA, vetorB, vetorC, vetorD);
            imprimevetor(vetorC);
            imprimevetor(vetorD);

        }
        static void levetor(int[] vetor)
        {
            Console.WriteLine("digite o numero: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("posição {0}: ", i + 1);
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
        static void imprimevetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("o numero do vetor na posição {0} é {1}", i + 1, vetor[i]);
            }
        }
        static void comparavetor(int[] A, int[] B, int[] C, int[] D)
        {
            int cont = 0;
            for (int i = 0; i < A.Length; i++)
            {
                bool compA = false;
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        compA = true;
                    }
                }
                if (compA == true)
                {
                    C[cont] = A[i];
                    cont++;
                }
                else
                {
                    int posicao = i - cont;
                    D[posicao] = A[i];
                }

            }
        }
        static void atv04() // ATIVIDADE 04
        {
            int[,] matriz = new int[3, 5];
            lematriz(matriz);
            somamatriz(matriz);
        }

        static void lematriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("coluna {0}, linha {1}: ", i, j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
        }
        static void imprimematriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                    Console.Write(matriz[i, j] + "\t");
                Console.WriteLine();
            }
        }

        static void somamatriz(int[,] matriz)
        {
            int somalinha = 0; int somacol = 0; int control = 0;
            for (int l = 0; l < matriz.GetLength(0); l++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    for (int k = 0; k < matriz.GetLength(0); k++)
                    {
                        somacol += matriz[k, c];
                    }
                    if (control < matriz.GetLength(1))
                    {
                        Console.WriteLine("soma da coluna {0} = {1}", c + 1, somacol);
                        somacol = 0;
                        control += 1;
                    }
                }
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    somalinha += matriz[l, i];
                }
                Console.WriteLine("soma da linha {0} é {1}",l+1,somalinha);
            }

        }


        static void atv05() // ATIVIDADE 05
        {
            Console.Write("digite um numero: ");
            int numero = int.Parse(Console.ReadLine());
            numero = fat(numero);
            Console.WriteLine(numero);

        }
        static int fat(int num)
        {
            int fat = 1;
            for (int i = 1; num >= i; num--)
            {
                fat = fat * num;
            }
            return fat;
        }

        static void atv06() // ATIVIDADE 06
        {
            Console.WriteLine("calcular potencia");
            Console.Write("digite a base: ");
            int Base = int.Parse(Console.ReadLine());
            Console.Write("digite a potencia: ");
            int potencia = int.Parse(Console.ReadLine());
            double resultado = 0;
            resultado = Potencia(Base, potencia, ref resultado);
            Console.WriteLine(resultado);
        }
        static double Potencia(int Base, int Pow, ref double res)
        {
            res = Math.Pow(Base, Pow);
            return res;
        }
    }
}


