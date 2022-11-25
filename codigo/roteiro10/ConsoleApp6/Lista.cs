
using dinamico;

namespace ConsoleApp6
{
    internal class Lista
    {
        public static void InserirLista(ref Elemento primeiro, ref Elemento ultimo, ref Elemento novo)
        {
            char op; int i;
            int pos = 0;
            Console.Write("Deseja selecionar uma posição para inserir? ");
            op = char.Parse(Console.ReadLine().ToLower());
            if (op == 's')
            {
                Console.Write("Digite a posição que deseja inserir: ");
                pos = int.Parse(Console.ReadLine());
                Elemento pesq = primeiro.proximo; // 1
                i = 0;
                while (i < pos)
                {
                    if (pos == 1)
                    {
                        Elemento Aux = primeiro.proximo;
                        primeiro.proximo = novo;
                        novo.proximo = Aux;
                    }
                    if (i == pos - 2)
                    {
                        Elemento Aux = pesq.proximo; // 2
                        pesq.proximo = novo;
                        novo.proximo = Aux;
                    }
                    else
                    {
                        pesq = pesq.proximo;
                    }
                    i++;
                }
            }
            else
            {
                ultimo.proximo = novo;
                ultimo = ultimo.proximo;
            }
        }


        public static void RemoverLista(ref Elemento primeiro, ref Elemento ultimo)
        {
            Elemento pesq = primeiro.proximo;
            Elemento Rem = new Elemento();
            int i = 0;
            Console.WriteLine("Digite a posição no qual voce deseja remover!");
            int remover = int.Parse(Console.ReadLine());
            remover -= 1;
            while (i < remover)
            {
                if (remover == 1)
                {
                    Rem = primeiro.proximo;
                }

                else if (i == remover - 1)
                {
                    Rem = pesq.proximo;
                    pesq.proximo = pesq.proximo.proximo;
                }
                else
                {
                    pesq = pesq.proximo;
                }
                i++;
            }
            Console.WriteLine("Removido: " + Rem.funcionario.ToString());
        }
    }
}
