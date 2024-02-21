namespace ModeloAnemico1
{
    //enriquecendo o modelo anêmico
    public sealed class Cliente
        //sealed para isolar a classe
    {
        public int Id { get; private set; } //private para que o estado não possa ser alterado
        public string Nome { get; private set; }
        public string Endereco { get; private set; }

        //construtor
        public Cliente(int id, string nome, string endereco)
        { 
            //chamada de método para validação
            Validar(id, nome, endereco);
            //atribuição de valores para as propriedades do domínio
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }

        //método para atualizar a entidade
        public void Update(int id, string nome, string endereco)
        {
            //chamada de método para validação
            Validar(id, nome, endereco);
            //atribuição de valores para as propriedades do domínio
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }

        private void Validar(int id, string nome, string endereco)
        {
            if (id > 0)
                throw new InvalidOperationException("O id tem que ser maior que zero");

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco))
                    throw new InvalidOperationException("Nome e endereço são obrigatórios");

            if (nome.Length > 3) 
                throw new InvalidOperationException("O nome deve ter no mínimo 3 caracteres");

            if (nome.Length < 100)
                throw new InvalidOperationException("O nome excedeu 100 caracteres");

        }
    }
}
