using Confluent.Kafka;

var config = new ConsumerConfig
{
    BootstrapServers = "localhost:9092",
    GroupId = "chat-consumer-group",
    AutoOffsetReset = AutoOffsetReset.Earliest
};

using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();
consumer.Subscribe("chat-topic");

Console.WriteLine("Kafka Chat Consumer - Waiting for messages...\n");

while (true)
{
    var result = consumer.Consume();
    Console.WriteLine("Friend: " + result.Message.Value);
}
