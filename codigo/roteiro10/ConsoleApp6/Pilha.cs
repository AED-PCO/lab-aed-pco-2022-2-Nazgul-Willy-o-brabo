
using dinamico;

namespace ConsoleApp6
{
     class Pilha
    {
        public static void InserirPilha(ref Elemento ultimo)
        {
            Console.WriteLine("Digite o nome do funcionario que deseja adicionar na pilha");
            string nome = Console.ReadLine();
            Console.WriteLine("Agora digite a matricula do funcionario");
            int id = int.Parse(Console.ReadLine());
            Elemento novo = new Elemento();
            novo.funcionario.Nome = nome;
            novo.funcionario.Id = id;

            ultimo.proximo = novo;
            ultimo = ultimo.proximo;
        }

        public static Elemento RemoverPilha(ref Elemento primeiro, ref Elemento ultimo)
        {
            Elemento aux = primeiro;

            while(aux.proximo != ultimo)
            {
                aux = aux.proximo;   
            }
            ultimo = aux;
            Console.WriteLine($"O valor removido foi {aux.proximo.funcionario.ToString()}");
            return aux.proximo;
        }

    }
}
