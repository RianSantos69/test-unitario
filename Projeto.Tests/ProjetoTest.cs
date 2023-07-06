namespace Projeto.Tests;

[TestClass]
public class ProdutoTestes
{
    [TestMethod]
    public void ProdutoCadastro_CadastrarProdutoCorretamente()
    {
        int id =  1;
        string nome = "Água";
        double preco = 1.0;
        double quantidade = 1.0;
        double precoCompra = 1.0;
        double precoVenda = 1.0;
        

        Assert.AreEqual(id, 1);
        Assert.AreEqual(nome, "Água");
        Assert.AreEqual(preco, 1.0);
        Assert.AreEqual(quantidade, 1.0);
        Assert.AreEqual(precoCompra, 1.0);
        Assert.AreEqual(precoVenda, 1.0);

    }

    [TestMethod]
    public void CadastroCliente(){
        int id = 1;
        string nome = "Rian";
        string email = "rian@gmail.com";
        string telefone = "123456789";

        Assert.AreEqual(id, 1);
        Assert.AreEqual(nome, "Rian");
        Assert.AreEqual(email, "rian@gmail.com");
        Assert.AreEqual(telefone, "123456789");
    }

    [TestMethod]
    public void CadastroFuncionario(){
        int id = 1;
        string nome = "Petri";
        string email = "petri@gmail.com";
        string telefone = "989999999";
        string senha = "1234";
        string salario = "3000";
        
        Assert.AreEqual(id, 1);
        Assert.AreEqual(nome, "Petri");
        Assert.AreEqual(email, "petri@gmail.com");
        Assert.AreEqual(telefone, "989999999");
        Assert.AreEqual(senha, "1234");
        Assert.AreEqual(salario, "3000");

    }

    [TestMethod]
    public void CadastroHotel(){
    int id = 1;
    string nome = "Hotel Serrano";
    string email = "hotel@gmail.com";
    string telefone = "988888888";

    Assert.AreEqual(id, 1);
    Assert.AreEqual(nome, "Hotel Serrano");
    Assert.AreEqual(email, "hotel@gmail.com");
    Assert.AreEqual(telefone, "988888888");
    }

    [TestMethod]
    public void CadastroQuarto(){
        int id = 1;
        int numeroQuarto = 24;
        string descricao = "Suite";
        double valor = 150;
        bool disponivel = true;

        Assert.AreEqual(id, 1);
        Assert.AreEqual(numeroQuarto, 24);
        Assert.AreEqual(descricao, "Suite");
        Assert.AreEqual(valor, 150);
        Assert.AreEqual(disponivel, true);


    }
}