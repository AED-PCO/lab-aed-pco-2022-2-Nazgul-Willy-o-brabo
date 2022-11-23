using dinamico;

namespace dinamico
{
    internal class Fila
    {
        public static void InserirFila(ref Elemento ultimo)
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
        public static void RemoveFila(ref Elemento primeiro, ref Elemento ultimo)
        {
            if(primeiro == ultimo)
            {
                Console.WriteLine("fila vazia!");
            }
            else { 
            Console.WriteLine($"Removido com sucesso o item {primeiro.proximo.funcionario.Nome} da fila!\nFila atualizada");
            primeiro = primeiro.proximo;
            }
        }
        public static void MostrarFila(ref Elemento primeiro, ref Elemento ultimo)
        {
            Elemento pesquisar;
            pesquisar = primeiro;
            while (pesquisar != ultimo)
            {
                Console.WriteLine(pesquisar.proximo.funcionario.ToString());
                pesquisar = pesquisar.proximo;
            }
        }
    }
}