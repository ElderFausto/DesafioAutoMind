using DesafioAutoMind.Models;

namespace DesafioAutoMind.Controllers
{
  public class UserController
  {
    private List<User> users = new List<User>();
    // adiciona usuario a lista
    public void AddUser(string name, string email, int age)
    {
      users.Add(new User(name, email, age));
      Console.Write("Usuario cadastrado!");
    }
    // retorna todos os usuarios cadastrados
    public List<User> GetUsers()
    {
      return users;
    }
  }
}