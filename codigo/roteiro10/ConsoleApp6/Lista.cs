using dinamico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Lista
    {
        public static void InserirLista(ref Elemento ultimo) {
            char op;
            Console.Write("Deseja selecionar uma posição para inserir? ");
            op = char.Parse(Console.ReadLine().ToLower());
            if (op == 's')
            {

            }
            else
            {
                Console.WriteLine("Digite o nome do funcionario que deseja adicionar na fila");
                string nome = Console.ReadLine();
                Console.WriteLine("Agora digite a matricula do funcionario");
                int id = int.Parse(Console.ReadLine());
                Elemento novo = new Elemento();
                novo.funcionario.Nome = nome;
                novo.funcionario.Id = id;

                ultimo.proximo = novo;
                ultimo = ultimo.proximo;
            }
         
        }

        public static void RemoverLista(ref Elemento primeiro, ref Elemento ultimo)
        {
            Console.WriteLine("Digite a posição no qual voce deseja remover!");
            int remover = int.Parse(Console.ReadLine());
            for (int i=0; i < remover-1; i++)
            {

            }
        }
    }
}
