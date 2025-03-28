﻿using Ecommerce.OrderMS.Domain.Model;
using FluentValidation;

namespace Ecommerce.OrderMS.Application.Validators;

public class OrderItemUpdateRequestValidator : AbstractValidator<OrderItemUpdateRequest>
{
    public OrderItemUpdateRequestValidator()
    {
        //ProductID
        RuleFor(temp => temp.ProductID)
          .NotEmpty().WithErrorCode("Product ID can't be blank");

        //UnitPrice
        RuleFor(temp => temp.UnitPrice)
          .NotEmpty().WithErrorCode("Unit Price can't be blank")
          .GreaterThan(0).WithErrorCode("Unit Price can't be less than or equal to zero");

        //Quantity
        RuleFor(temp => temp.Quantity)
          .NotEmpty().WithErrorCode("Quantity can't be blank")
          .GreaterThan(0).WithErrorCode("Quantity can't be less than or equal to zero");
    }
}
