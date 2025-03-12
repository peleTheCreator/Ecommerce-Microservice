namespace Ecommerce.OrderMS.Domain.Model.RabbitMQ;

public record ProductNameUpdateMessage(Guid ProductID, string? NewName);