using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Menu
    {

        public void menuFila()
        {
            Fila filaP = new Fila();
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
                    filaP.inserirFila(fila, ref Ref);
                }
                else if (op == "re")
                {
                    filaP.removerFila(fila, ref Ref);
                }
                else if (op == "vi")
                {
                    filaP.visualizarFila(fila, ref Ref);
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
        public void menuPilha()
        {
            Pilha pilhaP = new Pilha();
            Fila filaP = new Fila();
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
                    filaP.inserirFila(fila, ref Ref);
                }
                else if (op == "re")
                {
                    pilhaP.removerPilha(fila, ref Ref);
                }
                else if (op == "vi")
                {
                    filaP.visualizarFila(fila, ref Ref);
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
        public void menuLista()
        {
            Lista lista = new Lista();
            string op;
            string rep;
            Console.WriteLine("--LISTA--\n\n");
            int[] fila = new int[5];
            int Ref = 0;
            do
            {
                Console.WriteLine("Digite uma operação:\nin = inserir\nre = remover\nvi = visualizar\n");
                op = Console.ReadLine().ToLower();
                if (op == "in")
                {
                    lista.inserirLista(fila, ref Ref);
                }
                else if (op == "re")
                {
                    lista.removerLista(fila, ref Ref);
                }
                else if (op == "vi")
                {

                    lista.visualizarFila(fila, ref Ref);
                }
                else
                {
                    Console.WriteLine("Valor invalido");
                }
                Console.WriteLine("\nOutra operaçao\ns = sim\nn = não\n");
                rep = Console.ReadLine().ToLower();
            } while (rep == "s");
        }
    }
}
