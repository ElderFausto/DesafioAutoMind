namespace DesafioAutoMind.Models
{
  public class User
  {
    // cria as variaveis para receber os parametros de usuario
    public string Name { get; }
    public string Email { get; }
    public int Age { get; }

    public User(string name, string email, int age)
    {
      Name = name;
      Email = email;
      Age = Age;
    }
    
    // retorna os parametros passados pelo usuario
    public override string ToString()
    {
      return $"Nome: {Name}, Email: {Email}, Idade: {Age}";
    }
  }
}