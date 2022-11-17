using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lista
    {
        public void inserirLista(int[] fila, ref int Ref)
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
        public void removerLista(int[] fila, ref int Ref)
        {
            if (Ref > 0)
            {
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
        public void visualizarFila(int[] fila, ref int Ref)
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

    }
}
