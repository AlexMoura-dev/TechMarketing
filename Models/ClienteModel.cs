using System.ComponentModel;

namespace Cliente.Models;

public class ClienteModel
{
    public Guid Id { get; init; }
    public int clienteTotal { get; set; }
    public int clienteSatisfeito { get; set; }
    

}