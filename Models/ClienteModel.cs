using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechMarketing.Models;

[Table ("Clientes")]
public class ClienteModel
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("cliente_total")]
    public int ClienteTotal { get; set; }

    [Column("cliente_satisfeito")]
    public int ClienteSatisfeito { get; set; }
    

}