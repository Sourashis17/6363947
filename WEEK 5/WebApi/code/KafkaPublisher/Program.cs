using Confluent.Kafka;

var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

using var producer = new ProducerBuilder<Null, string>(config).Build();

Console.WriteLine("Kafka Chat Publisher - Type a message and hit Enter");

while (true)
{
    Console.Write("You: ");
    var message = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(message)) continue;

    await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });
    Console.WriteLine("Message sent.");
}
