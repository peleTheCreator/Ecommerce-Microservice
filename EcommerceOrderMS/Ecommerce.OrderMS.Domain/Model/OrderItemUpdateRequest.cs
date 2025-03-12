namespace Ecommerce.OrderMS.Domain.Model;

public record OrderItemUpdateRequest(Guid ProductID, decimal UnitPrice, int Quantity)
{
  public OrderItemUpdateRequest() : this(default, default, default)
  {
  }
}
