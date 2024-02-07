namespace APIModelo.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NumeroCelular { get; set; }
        public DateOnly DataNascimento { get; set; }

        //Método contando todos os dados

        public List<Pessoa> Dados() 
        { 

            //List<Pessoa> ListaPessoa = new List<Pessoa>(); "São a mesma coisa"

            //List<Pessoa> ListaPessoa = new();

            var ListaPessoas = new List<Pessoa>();

            var vPessoa = new Pessoa();
            vPessoa.Id = 1;
            vPessoa.Nome = "Pedro";

            var vPessoa2 = new Pessoa();
            vPessoa2.Id = 2;
            vPessoa2.Nome = "Maria";

            var vPessoa3 = new Pessoa();
            vPessoa3.Id = 3;
            vPessoa3.Nome = "Marcos";

            ListaPessoas.Add(vPessoa);
            ListaPessoas.Add(vPessoa2);
            ListaPessoas.Add(vPessoa3);

            return ListaPessoas;
        }
    }
}
