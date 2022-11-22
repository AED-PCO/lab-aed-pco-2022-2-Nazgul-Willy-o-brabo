using dinamico;
namespace dinamico
{
    internal class Fila
    {
        public static void InserirFila(ref Dados.Elemento ultimo)
        {
            Console.WriteLine("Digite o nome do funcionario que deseja adicionar na fila");
            string nome = Console.ReadLine();
            Console.WriteLine("Agora digite a matricula do funcionario");
            int id = int.Parse(Console.ReadLine());
            Dados.Elemento novo = new Dados.Elemento();
            novo.funcionario.Nome = nome;
            novo.funcionario.Id = id;

            ultimo.proximo = novo;
            ultimo = ultimo.proximo;
        }
        public static void MostrarFila(ref Dados.Elemento primeiro, ref Dados.Elemento ultimo)
        {
            Dados.Elemento pesquisar;
            pesquisar = primeiro;
            while (pesquisar != ultimo.proximo)
            {
                Console.WriteLine(pesquisar.funcionario.Nome);
                pesquisar = pesquisar.proximo;
            }
        }
    }
}
