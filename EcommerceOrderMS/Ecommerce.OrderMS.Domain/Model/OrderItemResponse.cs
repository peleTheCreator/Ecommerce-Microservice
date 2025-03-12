﻿namespace Ecommerce.OrderMS.Domain.Model;

public record OrderItemResponse(Guid ProductID, decimal UnitPrice, int Quantity, decimal TotalPrice, string? ProductName, string? Category)
{
  public OrderItemResponse() : this(default, default, default, default, default, default)
  {
  }
}
