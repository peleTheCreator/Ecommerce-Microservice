using Ecommerce.UserMS.Domain.Enum;

namespace Ecommerce.UserMS.Domain.Model.RequestDto
{
    public record RegisterRequest(
   string? Email,
   string? Password,
   string? PersonName,
   GenderOptions Gender);
}
