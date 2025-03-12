namespace Ecommerce.ProductMS.Domain.Model.RabbitMQ;

public record ProductNameUpdateMessage(Guid ProductID, string? NewName);
