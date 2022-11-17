
namespace ConsoleApp1
{
    class Fila
    {
        public void inserirFila(int[] fila, ref int Ref)
        {
            if (Ref < fila.Length)
                while (Ref < fila.Length)
                {
                    Console.Write("Digite o valor a ser inserido na posição {0}: ", Ref + 1);
                    fila[Ref] = int.Parse(Console.ReadLine());
                    Ref++;
                }
            else
                Console.WriteLine("Sua fila está cheia, utilize outra operação\n");
        }
        public void removerFila(int[] fila, ref int Ref)
        {
            int aux = fila[0];
            for (int i = 0; i < fila.Length - 1; i++)
            {
                fila[i] = fila[i + 1];
            }
            Ref--;
            Console.WriteLine("Removido com sucesso o primeiro item : {0}", aux);
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
