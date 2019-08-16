using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace Alici
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionFactory = new ConnectionFactory()
            {
                HostName = Properties.Resources.HostName
            };
            var connection = connectionFactory.CreateConnection();
            var channel = connection.CreateModel();
            string kuyruk = "TestKuyruğu";
            channel.QueueDeclare(kuyruk, true, false, false, null);

            Console.Write("Alış yöntemini seçin (1: EventingBasic, 2: Basic): ");
            int alisYontemi = Convert.ToInt16(Console.ReadLine());

            switch (alisYontemi)
            {
                case 1:
                    using (channel)
                    {
                        var alici = new EventingBasicConsumer(channel);
                        alici.Received += (model, tasinan) =>
                        {
                            var mesajByte = tasinan.Body;
                            var mesaj = Encoding.UTF8.GetString(mesajByte);

                            Console.WriteLine("Mesaj alındı: " + mesaj);
                        };

                        channel.BasicConsume(kuyruk, false, alici);
                    }
                    break;
                case 2:
                    using (channel)
                    {
                        var result = channel.BasicGet(kuyruk, false);
                        var mesajByte = result.Body;
                        var mesaj = Encoding.UTF8.GetString(mesajByte);
                        Console.WriteLine("Mesaj alındı: " + mesaj);
                        channel.BasicAck(result.DeliveryTag, false);
                    }
                    break;
            }
        }
    }
}
