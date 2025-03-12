namespace Ecommerce.ProductMS.Application.Service.RabbitMQ;

public interface IRabbitMQPublisher
{
    void Publish<T>(string routingKey, T message);
}
