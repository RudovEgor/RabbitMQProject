using RabbitMQ.Client;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProjectRabbitMQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)// отправить данные 
        {
            
                int timeToSleep = new Random().Next(1000, 3000);//от 1 до 3 секунд
                Thread.Sleep(timeToSleep);
                var factory = new ConnectionFactory() { HostName = "localhost" };
                using (var connection = factory.CreateConnection())
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "dev-queue",
                        durable: false,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null);
                    string message = messageBox.Text;
                     var body = Encoding.UTF8.GetBytes(message);
                    channel.BasicPublish(exchange: "",
                        routingKey: "dev-queue",
                    basicProperties: null,
                        body: body);
                listBox1.Items.Add("Вы отправили: "+messageBox.Text+"!");
                }
        }
    }
}
