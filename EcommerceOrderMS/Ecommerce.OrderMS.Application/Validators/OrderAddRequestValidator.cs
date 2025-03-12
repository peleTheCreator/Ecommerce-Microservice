using Ecommerce.OrderMS.Domain.Model;
using FluentValidation;

namespace Ecommerce.OrderMS.Application.Validators;

public class OrderAddRequestValidator : AbstractValidator<OrderAddRequest>
{
    public OrderAddRequestValidator()
    {
        //UserID
        RuleFor(temp => temp.UserID)
          .NotEmpty().WithErrorCode("User ID can't be blank");

        //OrderDate
        RuleFor(temp => temp.OrderDate)
          .NotEmpty().WithErrorCode("Order Date can't be blank");

        //OrderItems
        RuleFor(temp => temp.OrderItems)
          .NotEmpty().WithErrorCode("Order Items can't be blank");
    }
}
