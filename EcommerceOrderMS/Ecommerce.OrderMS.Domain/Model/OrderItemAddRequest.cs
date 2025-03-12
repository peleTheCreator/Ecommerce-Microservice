namespace Ecommerce.OrderMS.Domain.Model;

public record OrderItemAddRequest(Guid ProductID, decimal UnitPrice, int Quantity)
{
  public OrderItemAddRequest() : this(default, default, default)
  {
  }
}
