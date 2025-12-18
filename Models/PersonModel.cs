namespace Person.Models;

public class PersonModel
{
    public PersonModel(string nome)
    {
        Nome = nome; 
        Id = Guid.NewGuid();
    }
    public Guid Id { get; init; }
    public string Nome { get; private set; }
}