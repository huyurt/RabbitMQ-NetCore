using RabbitMQ.Client;
using System;
using System.Text;

namespace Gonderici
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

            string mesaj = "Kuyruğa gönderilen, kuyruktan gelen mesaj";
            var mesajByte = Encoding.UTF8.GetBytes(mesaj);

            channel.BasicPublish("", kuyruk, null, mesajByte);

            Console.WriteLine("Mesaj gönderildi: " + mesaj);
        }
    }
}
