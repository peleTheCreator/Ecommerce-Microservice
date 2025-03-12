namespace Ecommerce.OrderMS.Domain.Model;

public record ProductDTO(Guid ProductID, string? ProductName, int Category, double UnitPrice, int QuantityInStock);
