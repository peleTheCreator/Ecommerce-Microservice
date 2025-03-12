namespace Ecommerce.OrderMS.Domain.Model;

public record OrderAddRequest(Guid UserID, DateTime OrderDate, List<OrderItemAddRequest> OrderItems)
{
  public OrderAddRequest(): this(default, default, default)
  {
  }
}