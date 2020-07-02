using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ECommerce.Api.Orders.Db
{
  public class OrderItem
  {
    [Key]
    public int OrderId { get; set; }
      public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }

  }
}
