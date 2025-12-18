using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechMarketing.Models;

[Table("vendas")]
public class VendaModel
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("quantidade_venda")]
    public int QuantidadeVenda { get; set; }

    [Column("ano_venda")]
    public int AnoVenda { get; set; }

    [Column("meta_venda")]
    public int MetaVenda { get; set; }

}