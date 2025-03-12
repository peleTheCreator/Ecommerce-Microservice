namespace Ecommerce.ProductMS.Application.Service.Abstraction;

public interface IRabbitMQPublisher
{
    void Publish<T>(string routingKey, T message);
}
