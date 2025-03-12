namespace Ecommerce.UserMS.Domain.Model.ResponseDto;
public record AuthenticationResponse(
Guid UserID,
string? Email,
string? PersonName,
string? Gender,
string? Token,
bool Success
)
{
    //Required for AutoMapper & Serialization
    public AuthenticationResponse() : this(default, default, default, default, default, default)
    {
    }
}
