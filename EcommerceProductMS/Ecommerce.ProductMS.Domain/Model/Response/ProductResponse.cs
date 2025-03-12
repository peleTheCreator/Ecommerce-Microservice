using Ecommerce.ProductMS.Domain.Enum;

namespace Ecommerce.ProductMS.Domain.Model.Response;
public record ProductResponse(Guid ProductID, string ProductName, CategoryOptions Category, double? UnitPrice, int? QuantityInStock)
{
    public ProductResponse() : this(default, default, default, default, default)
    {
    }
}
