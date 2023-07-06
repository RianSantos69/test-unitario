namespace Projeto;

public class ProdutoTestes{
        public int ID {get; private set;}
        public string Nome  {get; private set;}
        public double Preco { get; private set;}
        public double Quantidade { get; private set; }
        public double PrecoVenda { get; private set; }
        public double PrecoCompra { get; private set; }


        public ProdutoTestes(int id, string nome, double preco, double quantidade, double precoVenda, double precoCompra){
            ID = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            PrecoVenda = precoVenda; 
            PrecoCompra = precoCompra;
        }
}

public class ClienteTestes{
        public int ID {get; private set;}
        public string Nome  {get; private set;}
        public string Telefone { get; private set;}
        public string Email { get; private set;}

        public ClienteTestes(int id, string nome, string telefone, string email){
            ID = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            }
}

public class FuncionarioTestes{
    public int ID {get; private set;}
    public string Nome  {get; private set;}
    public string Email { get; private set;}
    public string Telefone { get; private set;}
    public string Senha { get; private set;}
    public string Salario { get; private set;}

    public FuncionarioTestes(int id, string nome, string email, string telefone, string senha, string salario){
        ID = id;
        Nome = nome;
        Email = email;
        Telefone = telefone;
        Senha = senha;
        Salario = salario;
    }
}
public class HotelTestes{
    public int ID {get; private set;}
    public string Nome  {get; private set;}
    public string Endereco { get; private set;}
    public string Telefone { get; private set;}

    public HotelTestes(int id, string nome, string endereco, string telefone){
        ID = id;
        Nome = nome;
        Endereco = endereco;
        Telefone = telefone;
        }

}

public class QuartoTestes{
    public int ID {get; private set;}
    public int NumeroQuarto {get; private set;}
    public string Descricao {get; private set;}
    public double Valor {get; private set;}
    public bool Disponivel { get; private set; }

    public QuartoTestes(int id, int numeroQuarto, string descricao, double valor, bool disponivel){
        ID = id;
        NumeroQuarto = numeroQuarto;
        Descricao = descricao;
        Valor = valor;
        Disponivel = disponivel;
    }


}
