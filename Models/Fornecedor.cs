namespace LHPet.Models;

public class Fornecedor
{
    public int Id;
    public string Nome;
    public string Cnpj;
    public string Email;

    public Fornecedor(int id, string nome, string cnpj, string email)
    {
        Id = id;
        Nome = nome;
        Cnpj = cnpj;
        Email = email;
    }
}