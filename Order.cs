using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("order")]
public class Order
{
    [Key]
    public int OrderId { get; set; }
    public DateTime Date { get; set; }
    public int Amount { get; set; }
    public string Status { get; set; }
    public List<Product> ProductId { get; set; }
    public List<Quantity> QuantityId { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}



