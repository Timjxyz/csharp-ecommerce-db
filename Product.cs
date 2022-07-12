using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("product")]
public class Product
{
    [Key]
    public int ProductId { get; set; }
   
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public List<Order> Order_id { get; set; }
    public List<Quantity> Quantity_id { get; set; }
}
