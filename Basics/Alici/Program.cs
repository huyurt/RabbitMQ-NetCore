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
            channel.QueueDeclare(kuyruk, false, false, false, null);

            var alici = new EventingBasicConsumer(channel);
            alici.Received += (model, tasinan) =>
            {
                var mesajByte = tasinan.Body;
                var mesaj = Encoding.UTF8.GetString(mesajByte);

                Console.WriteLine("Mesaj alındı: " + mesaj);
            };

            channel.BasicConsume(kuyruk, true, alici);

            Console.ReadLine();
        }
    }
}
