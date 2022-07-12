using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class Quantity
{
    [Key]
    public int QuantityId { get; set; }
    public int OrderId { get; set; }
    public Order Orders { get; set; }
    public int ProductId { get; set; }
    public Product Products { get; set; }
}

