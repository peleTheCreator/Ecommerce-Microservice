using Ecommerce.ProductMS.Domain.Enum;

namespace Ecommerce.ProductMS.Domain.Model.Response;
public record ProductUpdateRequest(Guid ProductID, string ProductName, CategoryOptions Category, double? UnitPrice, int? QuantityInStock)
{
    public ProductUpdateRequest() : this(default, default, default, default, default)
    {
    }
}
