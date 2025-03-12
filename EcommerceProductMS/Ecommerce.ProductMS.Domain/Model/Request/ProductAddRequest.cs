using Ecommerce.ProductMS.Domain.Enum;

namespace Ecommerce.ProductMS.Domain.Model.Request;

public record ProductAddRequest(string ProductName, CategoryOptions Category, double? UnitPrice, int? QuantityInStock)
{
    public ProductAddRequest() : this(default, default, default, default)
    {
    }
}
