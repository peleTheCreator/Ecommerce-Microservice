namespace Ecommerce.OrderMS.Application.Service.RabbitMQ.Consumer.Abstraction;

public interface IRabbitMQProductNameUpdateConsumer
{
    void Consume();
    void Dispose();
}
