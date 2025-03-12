namespace Ecommerce.OrderMS.Domain.Model.RabbitMQ;

public record ProductDeletionMessage(Guid ProductID, string? ProductName);
