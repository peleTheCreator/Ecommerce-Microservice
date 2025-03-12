namespace Ecommerce.OrderMS.Application.Service.RabbitMQ.Consumer.Abstraction;

public interface IRabbitMQProductDeletionConsumer
{
    void Consume();
    void Dispose();
}

