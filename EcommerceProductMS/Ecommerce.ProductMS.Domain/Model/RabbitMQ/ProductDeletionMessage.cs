namespace Ecommerce.ProductMS.Domain.Model.RabbitMQ;

public record ProductDeletionMessage(Guid ProductID, string? ProductName);
