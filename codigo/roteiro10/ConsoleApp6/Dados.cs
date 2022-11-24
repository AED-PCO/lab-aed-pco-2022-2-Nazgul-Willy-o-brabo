namespace dinamico
{
        class Funcionario
        {
            public string Nome;
            public int Id;

        public override string ToString()
        {
            return "Livro: " 
                + Nome 
                + "\nCodigo: " 
                + Id;
        }
    }
         class Elemento
        {
            public Funcionario funcionario = new Funcionario();
            public Elemento proximo = null;

       
    }

    
    
        
}