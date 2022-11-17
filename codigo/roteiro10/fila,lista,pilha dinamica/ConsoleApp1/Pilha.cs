using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pilha
    {

        public void removerPilha(int[] fila, ref int Ref)
        {
            int aux = fila[Ref - 1];
            Ref--;
            Console.WriteLine("Removido com sucesso o ultimo item disponivel da pilha : {0}", aux);
        }

    }
}
