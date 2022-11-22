namespace dinamico
{
    internal class Dados
    {
        public class Funcionario
        {
            public string Nome;
            public int Id;
        }
        public class Elemento
        {
            public Funcionario funcionario = new Funcionario();
            public Elemento proximo = null;
        }
    }
}
